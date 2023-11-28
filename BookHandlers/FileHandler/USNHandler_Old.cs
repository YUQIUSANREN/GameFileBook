using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static BookHandlers.FileHandler.UsnReader;

namespace BookHandlers.FileHandler
{
    public class USNHandler_Old
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr CreateFile(string lpFileName, int dwDesiredAccess,
            int dwShareMode, IntPtr lpSecurityAttributes, int dwCreationDisposition,
            int dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);

        [DllImport("usnlib.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool ReadUsnJournal(IntPtr volumeHandle, IntPtr buffer,
            uint bufferBytes, ref WIN32_FIND_DATA usnEntry, uint filterFlags,
            out uint bytesRead, IntPtr overlapped, IntPtr lpfnNotifyRoutine);

        public void GetVolumeHandle()
        {
            IntPtr volumeHandle = CreateFile(@"\\.\C:", GENERIC_READ, FILE_SHARE_READ,
                IntPtr.Zero, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, IntPtr.Zero);
            if (volumeHandle.ToInt32() == INVALID_HANDLE_VALUE)
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            const int BUFFER_SIZE = 65536; // 64 KB
            IntPtr buffer = Marshal.AllocHGlobal(BUFFER_SIZE);
            uint bytesRead;

            WIN32_FIND_DATA usnEntry = new WIN32_FIND_DATA();
            bool success = ReadUsnJournal(volumeHandle, buffer, BUFFER_SIZE,
                ref usnEntry, 0, out bytesRead, IntPtr.Zero, IntPtr.Zero);

            if (!success)
            {
                CloseHandle(volumeHandle);
                Marshal.FreeHGlobal(buffer);
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            // 解析USN日志并进行相应处理
            // ...
            ParseUsnRecord(volumeHandle, bytesRead);

            CloseHandle(volumeHandle);
            Marshal.FreeHGlobal(buffer);
        }
        // 解析USN记录的方法
        private static uint ParseUsnRecord(IntPtr buffer, uint bytesRead)
        {
            uint offset = 0;

            while (offset < bytesRead)
            {
                // 读取USN记录头的信息
                USN_RECORD record = Marshal.PtrToStructure<USN_RECORD>(IntPtr.Add(buffer, (int)offset));

                // 提取常见属性值
                ulong usn = record.Usn; // USN值
                uint reason = record.Reason; // 修改原因
                DateTime timestamp = ConvertFileTimeToDateTime(record.Timestamp); // 时间戳

                // 处理其他属性，根据需要进行解析和使用
                // ...

                // 更新偏移量，用于处理下一个USN记录
                offset += record.RecordLength;
            }
            return offset;
        }
        public static DateTime ConvertFileTimeToDateTime(FILETIME fileTime)
        {
            long highBits = (long)fileTime.dwHighDateTime << 32;
            long combined = highBits | fileTime.dwLowDateTime;
            return DateTime.FromFileTimeUtc(combined);
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct USN_RECORD
    {
        public uint RecordLength;
        public ushort MajorVersion;
        public ushort MinorVersion;
        public ulong FileReferenceNumber;
        public ulong ParentFileReferenceNumber;
        public ulong Usn;
        public FILETIME Timestamp;
        public uint Reason;
        public uint SourceInfo;
        public uint SecurityId;
        public FileAttributes FileAttributes;
        public ushort FileNameLength;
        public ushort FileNameOffset;

        // 可选的扩展记录数据
        // ...
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FILETIME
    {
        public uint dwLowDateTime;
        public uint dwHighDateTime;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WIN32_FIND_DATA
    {
        public uint dwFileAttributes;
        public FILETIME ftCreationTime;
        public FILETIME ftLastAccessTime;
        public FILETIME ftLastWriteTime;
        public uint nFileSizeHigh;
        public uint nFileSizeLow;
        public uint dwReserved0;
        public uint dwReserved1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string cFileName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        public string cAlternateFileName;
    }

    public class UsnReader
    {
        public const int GENERIC_READ = unchecked((int)0x80000000);
        public const int FILE_SHARE_READ = 0x00000001;
        public const int OPEN_EXISTING = 3;
        public const int FILE_ATTRIBUTE_NORMAL = 0x80;
        public const int INVALID_HANDLE_VALUE = -1;

    }
}
