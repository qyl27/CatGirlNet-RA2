﻿using System.ComponentModel.DataAnnotations;
using System.Net;

namespace CatGirlNet.RA2.Model.Game.Player;

public class RemoteSide : Side
{
    [Required]
    public required IPAddress Ip { get; set; }
    
    [Required]
    public required ushort Port { get; set; } 
}