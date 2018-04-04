using bliztafree.Core;
using bliztafree.Core.Services.Order;
using bliztafree.Core.Services.Settings;
using bliztafree.Core.ViewModels;
using bliztafree.Core.ViewModels.Base;
using bliztafree.UnitTests.Mocks;
using System.Threading.Tasks;
using Xunit;

namespace bliztafree.UnitTests
{
    public class OrderViewModelTests
    {
        public OrderViewModelTests()
        {
            ViewModelLocator.UpdateDependencies(true);
            ViewModelLocator.RegisterSingleton<ISettingsService, MockSettingsService>();
        }

        [Fact]
        public void OrderPropertyIsNullWhenViewModelInstantiatedTest()
        {
            var settingsService = new MockSettingsService();
            var orderService = new OrderMockService();
            var orderViewModel = new OrderDetailViewModel(settingsService, orderService);
            Assert.Null(orderViewModel.Order);
        }

        [Fact]
        public async Task OrderPropertyIsNotNullAfterViewModelInitializationTest()
        {
            var settingsService = new MockSettingsService();
            var orderService = new OrderMockService();
            var orderViewModel = new OrderDetailViewModel(settingsService, orderService);

            var order = await orderService.GetOrderAsync(1, GlobalSetting.Instance.AuthToken);
            await orderViewModel.InitializeAsync(order);

            Assert.NotNull(orderViewModel.Order);
        }

        [Fact]
        public async Task SettingOrderPropertyShouldRaisePropertyChanged()
        {
            bool invoked = false;
            var settingsService = new MockSettingsService();
            var orderService = new OrderMockService();
            var orderViewModel = new OrderDetailViewModel(settingsService, orderService);

            orderViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName.Equals("Order"))
                    invoked = true;
            };
            var order = await orderService.GetOrderAsync(1, GlobalSetting.Instance.AuthToken);
            await orderViewModel.InitializeAsync(order);

            Assert.True(invoked);
        }
    }
}