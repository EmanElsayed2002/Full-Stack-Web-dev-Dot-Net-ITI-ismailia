class Individual {
  private fullName: string;
  private yearsOld: number;
  private static instance: Individual;

  private constructor(fullName: string, yearsOld: number) {
    this.fullName = fullName;
    this.yearsOld = yearsOld;
  }

  static getInstance(fullName: string, yearsOld: number): Individual {
    if (!this.instance) {
      this.instance = new Individual(fullName, yearsOld);
    }
    return this.instance;
  }

  static retrieveInstance(): Individual | null {
    return this.instance ?? null;
  }

  displayDetails(): string {
    return `Full Name: ${this.fullName}, Age: ${this.yearsOld}`;
  }
}

const member1 = Individual.getInstance("Eman", 22);
console.log(member1.displayDetails());

const member2 = Individual.getInstance("Alaa", 25);
console.log(member2.displayDetails());

console.log(member1 === member2);
