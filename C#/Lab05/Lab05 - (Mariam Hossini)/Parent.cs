using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fifth_Lab
{
    // ////////////////////////////////////////////////////////Early Binding
    class ParentE
    {
        protected int id;
        protected string name;
        //Setters and Getters
        public void SetId(int _id) { id = _id; }
        public int GetId() { return id; }
        public string GetName() { return name; }
        public void SetName(string _name) { name = _name; }
        public ParentE()
        {
            id = 0;
            name = null;
        }
        public ParentE(string _name, int _id)
        {
            id = _id;
            name = _name;
        }
        public string Show()
        {
            return $"<Parent>:[My name is {name} and my id = {id}]";
        }

    }
    class ChildE : ParentE
    {
        protected int age;
        public void SetAge(int _age) { age = _age; }
        public int GetAge() { return age; }

        public ChildE() : base()
        {
            age = 0;
        }

        public ChildE(string _name, int _id, int _age) : base(_name, _age)
        {
            id = _id;

        }
        public string Show()
        {
            return $"<Child>:[My name is {name} and my id = {id}] and my age = {age}";
        }
    }

    class SubChildE : ChildE
    {
        protected string gender;
        public void SetGender(string _gender) { gender = _gender; }
        public string GetGender() { return gender; }

        public SubChildE() : base()
        {
            gender = null;
        }
        public SubChildE(string _name, int _id, int _age, string _gender) : base(_name, _id, _age)
        {
            gender = gender;
        }
        public string Show()
        {
            return $"<SubChild>:[My name is {name} and my id = {id}] and my age = {age} and my gender is {gender}";
        }
    }

    
    /// ///////////////////////////////////Late Binding/
    class ParentL
    {
        protected int id;
        protected string name;
        //Setters and Getters
        public void SetId(int _id) { id = _id; }
        public int GetId() { return id; }
        public string GetName() { return name; }
        public void SetName(string _name) { name = _name; }
        public ParentL()
        {
            id = 0;
            name = null;
        }
        public ParentL(string _name, int _id)
        {
            id = _id;
            name = _name;
        }
        public virtual string Show()
        {
            return $"<Parent>:[My name is {name} and my id = {id}]";
        }

    }
    class ChildL : ParentL
    {
        protected int age;
        public void SetAge(int _age) { age = _age; }
        public int GetAge() { return age; }

        public ChildL() : base()
        {
            age = 0;
        }

        public ChildL(string _name, int _id, int _age) : base(_name, _age)
        {
            id = _id;

        }
        public override string Show()
        {
            return $"<Child>:[My name is {name} and my id = {id} and my age = {age}]";
        }
    }

    class SubChildL : ChildL
    {
        protected string gender;
        public void SetGender(string _gender) { gender = _gender; }
        public string GetGender() { return gender; }

        public SubChildL() : base()
        {
            gender = null;
        }
        public SubChildL(string _name, int _id, int _age, string _gender) : base(_name, _id, _age)
        {
            gender = gender;
        }
        public override string Show()
        {
            return $"<SubChild>:[My name is {name} and my id = {id} and my age = {age} and my gender is {gender}]";
        }
    }
}
