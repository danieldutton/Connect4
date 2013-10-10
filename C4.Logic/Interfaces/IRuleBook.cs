using C4.Model;

namespace C4.Logic.Interfaces
{
    public interface IRuleBook
    {
        GameToken Has4InARowVertical(GameToken gameToken);

        GameToken Has4InARowHorizontal(GameToken gameToken);

        GameToken Has4InARowDiagonal(GameToken gameToken);

        bool HasDrawn();
    }
}
