namespace Calculator{
    class FloatingCalculator{

        private float a;
        private float b;

        public float GetA(){ return a; }
        public float GetB(){ return b; }

        public void SetA(float a){ this.a = a; }
        public void SetB(float b){ this.b = b; }

        public float Suma(){
            float c = this.a + this.b;
            return c;
        }

        public float Resta(){
            float c = this.a - this.b;
            return c;
        }

        public float Multiplicacion(){
            float c = this.a * this.b;
            return c;
        }

        public float Division(){
            float c = this.a / this.b;
            return c;
        }
    }
}