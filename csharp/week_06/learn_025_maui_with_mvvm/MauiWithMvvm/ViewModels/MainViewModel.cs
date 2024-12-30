using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shared.Models;
using Shared.Services;
using System.Collections.ObjectModel;

namespace MauiWithMvvm.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly CustomerService _customerService;

    public MainViewModel(CustomerService customerService)
    {
        _customerService = customerService;
        CustomerList = (ObservableCollection<Customer>)_customerService.GetCustomers();

        //foreach(Customer customer in _customerService.GetCustomers())
        //{
        //    CustomerList.Add(customer);
        //}
    }
    
    [ObservableProperty]
    private Customer _registrationForm = new();

    [ObservableProperty]
    private ObservableCollection<Customer> _customerList = [];

    [RelayCommand]
    public void AddContactToList()
    {
        if (RegistrationForm != null && !string.IsNullOrWhiteSpace(RegistrationForm.CompanyName))
        {
            var result = _customerService.AddCustomerToList(RegistrationForm);

            if (result)
            {
                CustomerList = (ObservableCollection<Customer>)_customerService.GetCustomers();
            }
        }
    }
}
