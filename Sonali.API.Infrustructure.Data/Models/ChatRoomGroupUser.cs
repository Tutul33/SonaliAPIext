using System;
using System.Collections.Generic;

namespace Sonali.API.Infrustructure.Data.Models;

public partial class ChatRoomGroupUser
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public int? GroupId { get; set; }

    public int? ReadStatus { get; set; }
}
