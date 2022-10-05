// See https://aka.ms/new-console-template for more information

using Mediator;


var roomList = new List<Room>();

for (int i = 0; i < 10; i++)
{
    roomList.Add(new Room(){RoomNumber = i+1});
}

var lobby = new Lobby(roomList.ToArray());


roomList[0].Reserve = true;

lobby.CheckReserve();

lobby.ShowNotReserveRooms();