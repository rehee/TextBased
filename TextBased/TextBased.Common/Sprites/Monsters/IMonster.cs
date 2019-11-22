using System;
using System.Collections.Generic;
using System.Text;

namespace TextBased.Common.Sprites.Monsters
{
  public interface IMonster : ISprite
  {
    int DropLevel { get; set; }
    decimal DropRateBase { get; set }
    decimal DropRateIncrease { get;set }
  }
}
