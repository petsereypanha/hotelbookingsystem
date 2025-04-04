namespace HotelManagementSystem.Patterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}