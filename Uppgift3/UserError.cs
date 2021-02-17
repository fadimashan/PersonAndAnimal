namespace PersonAndAnimal
{
    abstract class UserError
    {
        /* polymorfism allows you to code to an interface that reduces coupling, 
         * increases reusability, and makes your code easier to read.
         * 
         * Abstract class can inherit another class using extends keyword and implement an interface.
         * Interface can inherit only an inteface. Abstract class can be inherited using extends keyword.
         * Interface can only be implemented using implements keyword.
         */
        public abstract string UEMessage();

       
    }


    class NumericInputError : UserError
    {
        public override string UEMessage() => "You tried to use a numeric input in a text only field.This fired an error!";
       
    }


    class TextInputError: UserError
    {
        public override string UEMessage() => "You tried to use a text input in a numericonly field.This fired an error!";

    }


    class One : UserError
    {
        public override string UEMessage() => "Hello! this is the First! ";
        
    }

    class Two : UserError
    {
        public override string UEMessage() => "Hello! this is the Second!";
       
    }

    class Three : UserError
    {
        public override string UEMessage() => "Hello! this is the Third!";
      
    }


}