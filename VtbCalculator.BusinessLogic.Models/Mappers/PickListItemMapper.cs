using VtbCalculator.Common.Helpers.Enumerations;
using VtbCalculator.Domain.Models;

namespace VtbCalculator.BusinessLogic.Models.Mappers
{
    public static class PickListItemMapper
    {
        public static PickListItemModel ToPickListItemModel(OperationType operationType)
        {
            return new PickListItemModel {Id = (int) operationType, Name = operationType.GetDescription()};
        }
    }
}