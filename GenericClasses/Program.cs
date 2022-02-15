using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {










            Console.ReadLine();
        }
    }
    interface IEntity
    {

    }
    class Product:IEntity
    {

    }

    class Customer:IEntity
    {

    }

    interface ICustomerDal:IRepository<Customer>
    {

    }

    interface IProductDal:IRepository<Product>
    {

    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    interface IRepository<T> where T: class,IEntity,new()
    {
        //Class means referance type and new () can be only created new object if we only use class that we could declare like that ICustomerDal:IRepository<string> cause string is referance type if we use new () so we cannot create string as new and all classes should be implemented from IEntity and new () always should be in the end

        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

}
