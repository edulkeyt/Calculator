using System.Collections.Generic;
using System.Linq;
using VtbCalculator.BusinessLogic.Models;
using VtbCalculator.BusinessLogic.Models.Mappers;
using VtbCalculator.Common.Helpers.Enumerations;
using VtbCalculator.Domain.Models;

namespace VtbCalculator.WebApplication.PickLists
{
    public class OperationTypeDataProvider
    {
        public IEnumerable<PickListItemModel> GetItems()
        {
            return EnumValuesListHelper.GetValues<OperationType>()
                .Select(PickListItemMapper.ToPickListItemModel).ToArray();
        }
    }
}