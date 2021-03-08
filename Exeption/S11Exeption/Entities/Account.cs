using S11Exeption.Entities.Exceptions;
class Account {
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balace { get; set; }
    public double withdrawLimit { get; set; }

    public Account(int number, string holder, double balace, double withdrawLimit) {
        Number = number;
        Holder = holder;
        Balace = balace;
        this.withdrawLimit = withdrawLimit;
    }

    public void Deposit(double amount) {
        Balace += amount;

    }
    public void Withdraw(double amount) {

        if (amount > withdrawLimit) {

            throw new DomainException(" The amount exceeds withdraw limit");
        }

        if (amount > Balace) {

            throw new DomainException(" Not enough balance");
        }

        Balace -= amount;
    }
}

