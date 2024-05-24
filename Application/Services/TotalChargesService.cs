using Domain;
using Infrastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    
    public class TotalChargesService
    {
       private  IConsumerRepository _consumerRepository { get; set; }

        public TotalChargesService(IConsumerRepository consumerRepository)
        {
            // Initialize and store the mappings for material types, commodity codes, and duty percentages
            _consumerRepository= consumerRepository;
        }

        public double CalculateTotalCharges(IEnumerable<GoodItem> goodItems)
        {
            double totalCharges = 0;

            foreach (var item in goodItems)
            {
                    double totalPrice = item.Price * item.Quantity;
                    double dutyCharges = Convert.ToDouble(_consumerRepository.MaterialCommodityMappings().Where(x => x.MaterialType == item.MaterialType).FirstOrDefault().DutyPercentage) * totalPrice;
                    totalCharges += dutyCharges;
            }

            return totalCharges;
        }
    }
}
