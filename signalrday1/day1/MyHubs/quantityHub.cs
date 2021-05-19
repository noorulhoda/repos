using day1.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Day1.MyHubs
{
    //All Public MEthod Calling From Client As RPC
    //[HubName("ChatHub")]
    public class quantityHub : Hub
    {
        MyCompanyEntities context = new MyCompanyEntities();
        //[HubMethodName("NewUser")]
        public void newUser(string name)
        {

        }
        //Call Cient //Server
        //[HubMethodName("NewMessage")]
        public void boughtProduct(int id)
        {
            //save db ,....
            Products pr = context.Products.FirstOrDefault(p => p.Id == id);
            pr.Quantity--;
            context.SaveChanges();
            //Boradcast "Server Call Clinet Side MEthod Push
            Clients.All.notifyBoughtProduct(pr.Quantity);
        }
        public override Task OnConnected()
        {
            return base.OnConnected();
        }
    }
}