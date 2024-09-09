using Artan.DLL.Context;
using Artan.DLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artan.DLL.Services
{
    public class RepositoryOrders : IRepositoryOrders
    {
        Artan_DBEntities db_Artan;
        public RepositoryOrders(Artan_DBEntities entities)
        {
            db_Artan = entities;
        }

        public async Task<bool> DuplicateValueAsync(string orderDate, string senderName, string receiverName)
        {
            try
            {
                await Task.Run(() => db_Artan.vw_Orders.Any(x => x.OrderDate == orderDate && x.SenderName == senderName && x.ReceiverName == receiverName));
                return true;
            }
            catch { return false; }
        }

        public async Task<List<vw_Orders>> GetAllAsync()
        {
            try
            {
                return await Task.Run(() => db_Artan.vw_Orders.ToList());

            }
            catch { return null; }
        }

        public async Task<List<sp_OrderSearch_Result>> GetSearchAsync(string searchName)
        {
            try
            {
                return await Task.Run(() => db_Artan.sp_OrderSearch(searchName).ToList());

            }
            catch { return null; }
        }

        public async Task<bool> InsertAsync(int orderID, string orderDate, bool paymentStatus, int conditionID, int senderID, string sender, string senderName, string senderMobile, string senderAddress, int receiverID, string receiver, string receiverName, string receiverMobile, string receiverAddress, int postID, int packageID, bool payment, string weight, string number, string shippingCosts, string adminstrativeCosts, string discount, string totalCost, string description, string createDate)
        {
            try
            {
                await Task.Run(() => db_Artan.sp_OrderInsert(orderID, orderDate, paymentStatus, conditionID, senderID, sender, senderName, senderMobile, senderAddress, receiverID, receiver, receiverName, receiverMobile, receiverAddress, postID, packageID, payment, weight, number, shippingCosts, adminstrativeCosts, discount, totalCost, description, createDate));
                return true;
            }
            catch { return false; }
        }

        public async Task<bool> UpdateAsync(int orderID, string orderDate, bool paymentStatus, int conditionID, int senderID, string sender, string senderName, string senderMobile, string senderAddress, int receiverID, string receiver, string receiverName, string receiverMobile, string receiverAddress, int postID, int packageID, bool payment, string weight, string number, string shippingCosts, string adminstrativeCosts, string discount, string totalCost, string description)
        {
            try
            {
                await Task.Run(() => db_Artan.sp_OrderUpdate(orderID, orderDate, paymentStatus, conditionID, senderID, sender, senderName, senderMobile, senderAddress, receiverID, receiver, receiverName, receiverMobile, receiverAddress, postID, packageID, payment, weight, number, shippingCosts, adminstrativeCosts, discount, totalCost, description));
                return true;
            }
            catch { return false; }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                await Task.Run(() => db_Artan.sp_OrderDelete(id));
                return true;
            }
            catch { return false; }
        }
    }
}
