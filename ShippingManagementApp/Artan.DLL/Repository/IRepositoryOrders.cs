using Artan.DLL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artan.DLL.Repository
{
    public interface IRepositoryOrders
    {
        Task<bool> DuplicateValueAsync(string orderDate, string senderName, string receiverName);
        Task<List<vw_Orders>> GetAllAsync();
        Task<List<sp_OrderSearch_Result>> GetSearchAsync(string searchName);
        Task<bool> InsertAsync(int orderID, string orderDate, bool paymentStatus, int conditionID, int senderID, string sender, string senderName, string senderMobile
            , string senderAddress, int receiverID, string receiver, string receiverName, string receiverMobile, string receiverAddress, int postID, int packageID
            , bool payment, string weight, string number, string shippingCosts, string adminstrativeCosts, string discount, string totalCost, string description
            , string createDate);
        Task<bool> UpdateAsync(int orderID, string orderDate, bool paymentStatus, int conditionID, int senderID, string sender, string senderName, string senderMobile
            , string senderAddress, int receiverID, string receiver, string receiverName, string receiverMobile, string receiverAddress, int postID, int packageID
            , bool payment, string weight, string number, string shippingCosts, string adminstrativeCosts, string discount, string totalCost, string description
            );
        Task<bool> DeleteAsync(int id);
    }
}
