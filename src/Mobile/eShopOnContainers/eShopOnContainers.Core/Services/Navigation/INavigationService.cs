﻿using bliztafree.Core.ViewModels.Base;
using System.Threading.Tasks;

namespace bliztafree.Services
{
    public interface INavigationService
    {
		ViewModelBase PreviousPageViewModel { get; }

        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;

        Task RemoveLastFromBackStackAsync();

        Task RemoveBackStackAsync();
    }
}