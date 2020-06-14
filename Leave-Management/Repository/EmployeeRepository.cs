using Leave_Management.Contracts;
using Leave_Management.Data;
using System.Collections.Generic;
using System.Linq;

namespace Leave_Management.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;

        public EmployeeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Employee entity)
        {
            _db.Employees.Add(entity);
            return Save();
        }

        public bool Delete(Employee entity)
        {
            _db.Employees.Remove(entity);
            return Save();
        }

        public ICollection<Employee> FindAll()
        {
            return _db.Employees.ToList();
        }

        public Employee FindById(int id)
        {
            return _db.Employees.Find(id);
        }

        public Employee FindById(string id)
        {
            return _db.Employees.Find(id);
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(Employee entity)
        {
            _db.Employees.Update(entity);
            return Save();
        }

        public bool Exists(int id)
        {
            return _db.Employees.Any(e => e.Id.Equals(id));
        }
    }
}
