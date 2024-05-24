using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.IRepository
{
    public interface IConsumerRepository
    {
        string startConsuming();
        List<ClsCompany> GetCOmpanyDetails();
        List<ClsMaterialCommodityMapping> MaterialCommodityMappings();
        int saveDeclaration(ClsDeclaration model);
        int saveMessages(ClsMessage model);

        int saveEvents(ClsEvent model);
        int SaveGoodItems(ClsGoodsItem model);
    }
}
