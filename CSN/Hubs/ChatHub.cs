using Microsoft.AspNetCore.SignalR;

namespace CSN.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message, int roomId)
    {
        await Clients.Group(roomId.ToString())
            .SendAsync("ReceiveMessage", user, message);
    }

    public async Task JoinRoom(int roomId)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, roomId.ToString());
    }

    public async Task LeaveRoom(int roomId)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomId.ToString());
    }


}