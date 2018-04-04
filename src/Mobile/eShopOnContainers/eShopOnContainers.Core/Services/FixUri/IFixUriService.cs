using System.Collections.Generic;
using bliztafree.Core.Models.Basket;
using bliztafree.Core.Models.Catalog;
using bliztafree.Core.Models.Marketing;

namespace bliztafree.Core.Services.FixUri
{
    public interface IFixUriService
    {
        void FixCatalogItemPictureUri(IEnumerable<CatalogItem> catalogItems);
        void FixBasketItemPictureUri(IEnumerable<BasketItem> basketItems);
        void FixCampaignItemPictureUri(IEnumerable<CampaignItem> campaignItems);
    }
}
