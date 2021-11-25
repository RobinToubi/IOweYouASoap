using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GroupService.Services
{
    public class GroupableObject : IGroupableObject
    {
        public string Name { get; set; }
        public int GroupId { get; set; }
        public List<int> Members { get; set; }

        public static List<Group> Groups = new List<Group>()
            {
                new Group(0, "groupe1", new List<int>() { 1, 23, 534 }),
                new Group(1, "groupe2", new List<int>() { 1, 23, 534 }),
                new Group(2, "groupe3", new List<int>() { 1, 23, 534 }),
                new Group(3, "groupe4", new List<int>() { 1, 23, 534 }),
                new Group(4, "groupe5", new List<int>() { 1, 23, 534 }),
                new Group(5, "groupe6", new List<int>() { 1, 23, 534 }),
                new Group(6, "groupe7", new List<int>() { 1, 23, 534 })
        };

        public Group GetGroup(int id)
        {
            return Groups.Find(g => g.Id == id);
        }
    }

    [DataContract]
    public class Group
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<int> Members { get; set; }

        public Group(int id, string name, List<int> members)
        {
            Id = id;
            Name = name;
            Members = members;
        }
    }
}