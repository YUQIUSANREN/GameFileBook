﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Data;
using GameFileBook.Views;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;

namespace GameFileBook.Domain;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel(ISnackbarMessageQueue snackbarMessageQueue)
    {
        DemoItems = new ObservableCollection<DemoItem>(new[]
        {
            new DemoItem(
                "Home",
                typeof(Home),
                new[]
                {
                    new DocumentationLink(
                        DocumentationLinkType.Wiki,
                        $"{ConfigurationManager.AppSettings["GitHub"]}/wiki",
                        "WIKI"),
                    DocumentationLink.DemoPageLink<Home>()
                }
            )
        });

        foreach (var item in GenerateDemoItems(snackbarMessageQueue).OrderBy(i => i.Name))
        {
            DemoItems.Add(item);
        }
        SelectedItem = DemoItems.First();
        _demoItemsView = CollectionViewSource.GetDefaultView(DemoItems);
        _demoItemsView.Filter = DemoItemsFilter;
        

        HomeCommand = new AnotherCommandImplementation(
            _ =>
            {
                SearchKeyword = string.Empty;
                SelectedIndex = 0;
            });

        MovePrevCommand = new AnotherCommandImplementation(
            _ =>
            {
                if (!string.IsNullOrWhiteSpace(SearchKeyword))
                    SearchKeyword = string.Empty;

                SelectedIndex--;
            },
            _ => SelectedIndex > 0);

        MoveNextCommand = new AnotherCommandImplementation(
           _ =>
           {
               if (!string.IsNullOrWhiteSpace(SearchKeyword))
                   SearchKeyword = string.Empty;

               SelectedIndex++;
           },
           _ => SelectedIndex < DemoItems.Count - 1);
    }

    private readonly ICollectionView _demoItemsView;
    private DemoItem? _selectedItem;
    private int _selectedIndex;
    private string? _searchKeyword;
    private bool _controlsEnabled = true;

    public string? SearchKeyword
    {
        get => _searchKeyword;
        set
        {
            if (SetProperty(ref _searchKeyword, value))
            {
                _demoItemsView.Refresh();
            }
        }
    }

    public ObservableCollection<DemoItem> DemoItems { get; }

    public DemoItem? SelectedItem
    {
        get => _selectedItem;
        set => SetProperty(ref _selectedItem, value);
    }

    public int SelectedIndex
    {
        get => _selectedIndex;
        set => SetProperty(ref _selectedIndex, value);
    }

    public bool ControlsEnabled
    {
        get => _controlsEnabled;
        set => SetProperty(ref _controlsEnabled, value);
    }

    public AnotherCommandImplementation HomeCommand { get; }
    public AnotherCommandImplementation MovePrevCommand { get; }
    public AnotherCommandImplementation MoveNextCommand { get; }

    private static IEnumerable<DemoItem> GenerateDemoItems(ISnackbarMessageQueue snackbarMessageQueue)
    {
        if (snackbarMessageQueue is null)
            throw new ArgumentNullException(nameof(snackbarMessageQueue));

        yield return new DemoItem(
            "Files",
            typeof(Files),
            new[]
            {
                DocumentationLink.WikiLink("Button-Styles", "Buttons"),
                DocumentationLink.DemoPageLink<Files>("File Manage"),
                DocumentationLink.DemoPageLink<FilesViewModel>("File View Model", "Domain"),
                DocumentationLink.StyleLink("Button"),
                DocumentationLink.StyleLink("PopupBox"),
                DocumentationLink.ApiLink<PopupBox>()
            });

        yield return new DemoItem(
            "Games",
            typeof(Games),
            new[]
            {
                DocumentationLink.WikiLink("Button-Styles", "Buttons"),
                DocumentationLink.DemoPageLink<Games>("Demo View"),
                DocumentationLink.DemoPageLink<GamesViewModel>("Demo View Model", "Domain"),
                DocumentationLink.StyleLink("Button"),
                DocumentationLink.StyleLink("PopupBox"),
                DocumentationLink.ApiLink<PopupBox>()
            });
    }

    private bool DemoItemsFilter(object obj)
    {
        if (string.IsNullOrWhiteSpace(_searchKeyword))
        {
            return true;
        }

        return obj is DemoItem item
               && item.Name.ToLower().Contains(_searchKeyword!.ToLower());
    }
}
