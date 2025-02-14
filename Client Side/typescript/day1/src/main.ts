import { IUser } from "../src/models/user.model";

let user1: IUser = {
  id: 1,
  name: "Eman",
};

let users: IUser[] = [
  {
    id: 1,
    name: "Eman",
    email: "eman@gmail.com",
    address: {
      streetName: "street1",
      posterCode: "",
    },
  },
  {
    id: 2,
    name: "Alaa",
    address: {
      streetName: "street2",
      posterCode: "",
    },
  },
  {
    id: 3,
    name: "Hala",
    address: {
      streetName: "street3",
      posterCode: "",
    },
  },
  {
    id: 4,
    name: "Ahmed",
    address: {
      streetName: "street4",
      posterCode: "",
    },
  },
  {
    id: 5,
    name: "Hassan",
  },
];

function getUserById(id: number): IUser[] {
  return users.filter((user) => user.id === id);
}

function addNewUser(newUser: IUser): void {
  users.push(newUser);
}

function getAllUserWithAddress(): IUser[] {
  return users.filter((user) => user.address);
}

function updateUserEmail(email: string, id: number) {
  users.forEach((user) => {
    if (user.id === id) {
      user.email = email;
    }
  });
}

console.log(users);

console.log(getUserById(5));

console.log(addNewUser(user1));
console.log(users);

console.log(getAllUserWithAddress());

console.log(updateUserEmail("hi@gmail.com", 1));
console.log(users);
