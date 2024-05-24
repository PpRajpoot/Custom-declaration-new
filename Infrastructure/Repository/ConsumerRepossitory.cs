using Domain;
using Infrastructure.DBContext;
using Infrastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ConsumerRepossitory : IConsumerRepository
    {
        private readonly ConsumerContext _consumerContext;
        public ConsumerRepossitory(ConsumerContext consumerContext) {
        _consumerContext = consumerContext;
        }

        public string startConsuming()
        {
            return "";
        }

        public List<ClsCompany> GetCOmpanyDetails()
        {
            return _consumerContext.T_Company.ToList();
        }

        public List<ClsMaterialCommodityMapping> MaterialCommodityMappings() {
            return _consumerContext.T_MaterialCommodityMapping.ToList();
        }

        public int saveDeclaration(ClsDeclaration model)
        {
            try
            {
                _consumerContext.Add(model);
                _consumerContext.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int saveMessages(ClsMessage model)
        {
            try
            {
                _consumerContext.Add(model);
                _consumerContext.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int saveEvents(ClsEvent model)
        {
            try
            {
                _consumerContext.Add(model);
                _consumerContext.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int SaveGoodItems(ClsGoodsItem model)
        {
            try
            {
                _consumerContext.Add(model);
                _consumerContext.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
