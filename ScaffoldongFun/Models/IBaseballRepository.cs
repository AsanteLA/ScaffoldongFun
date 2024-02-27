namespace ScaffoldongFun.Models
{
    public interface IBaseballRepository
    {
        List<Manager> Managers { get; }

        public void AddManager(Manager manager);
    }
}
