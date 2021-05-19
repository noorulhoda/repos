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
    public class commentHub : Hub
    {
        MyCompanyEntities context = new MyCompanyEntities();
        //[HubMethodName("NewUser")]
        public void newUser(string name)
        {

        }
        //Call Cient //Server
        //[HubMethodName("NewMessage")]
        public void newMessage(string name, string text,int id)
        {
            //save db ,....
            Products pr = context.Products.FirstOrDefault(p => p.Id == id);
            pr.ReviewsCounter++;
            Reviews rv = new Reviews() { ReviewID= DateTime.Now.Millisecond,ReviewDetails = text, ProductId = pr.Id,CustomerId=1 };//customerId=identity.user.id
            context.Reviews.Add(rv);
            context.SaveChanges();
            //Boradcast "Server Call Clinet Side MEthod Push
            Clients.All.notifyNewMessage(name, text,id);// or Context.User.Identity.Name
        }
        public override Task OnConnected()
        {
            return base.OnConnected();
        }
    }
}