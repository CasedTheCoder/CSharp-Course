namespace Calculator{
    class IntegerCalculator{

        private int a;
        private int b;

        public int GetA(){ return a; }
        public int GetB(){ return b; }

        public void SetA(int a){ this.a = a; }
        public void SetB(int b){ this.b = b; }

        public int Suma(){
            int c = this.a + this.b;
            return c;
        }

        public int Resta(){
            int c = this.a - this.b;
            return c;
        }

        public int Multiplicacion(){
            int c = this.a * this.b;
            return c;
        }

        public int Division(){
            int c = this.a / this.b;
            return c;
        }
    }
}