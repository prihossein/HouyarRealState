using HouyarRealState.Domain.Entities.Properties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouyarRealState.Infrastructure.Persistence.Configurations.Properties
{
    public class TransactionTypeConfigurations : IEntityTypeConfiguration<TransactionType>
    {
        public void Configure(EntityTypeBuilder<TransactionType> builder)
        {


        }
    }
}
