namespace Chess.Figures.Contracts
{
    using System.Collections.Generic;

    using Common;
    using Movements.Contracts;

    public abstract class BaseFigure : IFigure
    {
  
        protected BaseFigure(ChessColor color)
        {
            this.Color = color;
        }

        public ChessColor Color { get; private set; }

        public abstract ICollection<IMovement> Move(IMovementStrategy strategy);
    }
}
