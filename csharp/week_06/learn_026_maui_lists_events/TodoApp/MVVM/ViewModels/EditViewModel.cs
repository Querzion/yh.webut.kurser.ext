using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TodoApp.MVVM.Models;
using TodoApp.Services;

namespace TodoApp.MVVM.ViewModels;

public partial class EditViewModel : ObservableObject
{
    private readonly TodoService _todoService;

    public EditViewModel(TodoService todoService)
    {
        _todoService = todoService;
    }

    [ObservableProperty]
    private TodoItem item = new();

    [RelayCommand]
    private async Task Update()
    {
        _todoService.Update(Item);
        Item = new();

        await Shell.Current.GoToAsync("..");
    }
}
