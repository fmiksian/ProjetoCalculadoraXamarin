using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace CalculadoraXamarin
{
    [Activity(Label = "MultiCalcV1", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView txtVisor;
        Button btnNumero0, btnNumero1, btnNumero2, btnNumero3, btnNumero4,
            btnNumero5, btnNumero6, btnNumero7, btnNumero8,
            btnNumero9, btnVirgula, btnIgual, btnSomar,
            btnSubtrair, btnMultiplicar, btnDividir, btnLimparCE,
            btnLimparC, btnElevarQuadrado, btnRaizQuadrada, btnSeno,
            btnCosseno, btnTangente, btnFatorial, btnConverter;
        Spinner spnConversao;
        Calculadora calculadora;
        int intOpcaoConversao = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            txtVisor = FindViewById<TextView>(Resource.Id.txtVisor);
            //Teclas Numericas
            btnNumero0 = FindViewById<Button>(Resource.Id.btnNumero0);
            btnNumero1 = FindViewById<Button>(Resource.Id.btnNumero1);
            btnNumero2 = FindViewById<Button>(Resource.Id.btnNumero2);
            btnNumero3 = FindViewById<Button>(Resource.Id.btnNumero3);
            btnNumero4 = FindViewById<Button>(Resource.Id.btnNumero4);
            btnNumero5 = FindViewById<Button>(Resource.Id.btnNumero5);
            btnNumero6 = FindViewById<Button>(Resource.Id.btnNumero6);
            btnNumero7 = FindViewById<Button>(Resource.Id.btnNumero7);
            btnNumero8 = FindViewById<Button>(Resource.Id.btnNumero8);
            btnNumero9 = FindViewById<Button>(Resource.Id.btnNumero9);
            //Teclas de virgula e sinal de igual
            btnVirgula = FindViewById<Button>(Resource.Id.btnVirgula);
            btnIgual = FindViewById<Button>(Resource.Id.btnIgual);
            //Tecla de Operadores
            btnSomar = FindViewById<Button>(Resource.Id.btnSomar);
            btnSubtrair = FindViewById<Button>(Resource.Id.btnSubtrair);
            btnMultiplicar = FindViewById<Button>(Resource.Id.btnMultiplicar);
            btnDividir = FindViewById<Button>(Resource.Id.btnDivdir);
            //Teclas de Limpeza
            btnLimparCE = FindViewById<Button>(Resource.Id.btnLimparCE);
            btnLimparC = FindViewById<Button>(Resource.Id.btnLimparC);
            //Teclas de funções matemáticas
            btnElevarQuadrado = FindViewById<Button>(Resource.Id.btnElevarQuadrado);
            btnRaizQuadrada = FindViewById<Button>(Resource.Id.btnRaizQuadrada);
            btnSeno = FindViewById<Button>(Resource.Id.btnSeno);
            btnCosseno = FindViewById<Button>(Resource.Id.btnCosseno);
            btnTangente = FindViewById<Button>(Resource.Id.btnTangente);
            btnFatorial = FindViewById<Button>(Resource.Id.btnFatorial);
            //conversão de unidades de medida
            spnConversao = FindViewById<Spinner>(Resource.Id.spnConversao);
            btnConverter = FindViewById<Button>(Resource.Id.btnConverter);

            calculadora = new Calculadora();

            btnNumero0.Click += OnTeclaNumeros;
            btnNumero1.Click += OnTeclaNumeros;
            btnNumero2.Click += OnTeclaNumeros;
            btnNumero3.Click += OnTeclaNumeros;
            btnNumero4.Click += OnTeclaNumeros;
            btnNumero5.Click += OnTeclaNumeros;
            btnNumero6.Click += OnTeclaNumeros;
            btnNumero7.Click += OnTeclaNumeros;
            btnNumero8.Click += OnTeclaNumeros;
            btnNumero9.Click += OnTeclaNumeros;
            btnVirgula.Click += OnTeclaVirgula;
            btnIgual.Click += OnTeclaIgual;
            btnSomar.Click += OnTeclaSomar;
            btnSubtrair.Click += OnTeclaSubtrair;
            btnMultiplicar.Click += OnTeclaMultiplicar;
            btnDividir.Click += OnTeclaDividir;
            btnLimparCE.Click += OnTeclaLimparCE;
            btnLimparC.Click += OnTeclaLimparC;
            btnElevarQuadrado.Click += OnTeclaElevarQuadrado;
            btnRaizQuadrada.Click += OnTeclaRaizQuadrada;
            btnSeno.Click += OnTeclaSeno;
            btnCosseno.Click += OnTeclaCosseno;
            btnTangente.Click += OnTeclaTangente;
            btnFatorial.Click += OnTeclaFatorial;
            btnConverter.Click += OnteclaConversao;
            spnConversao.ItemSelected += new System.EventHandler<AdapterView.ItemSelectedEventArgs>(OnItemSelecionado);

        }

        private void OnItemSelecionado(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            intOpcaoConversao = e.Position;
        }
        private void OnteclaConversao(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaFatorial(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaTangente(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaCosseno(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaSeno(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaRaizQuadrada(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaElevarQuadrado(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaLimparC(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaLimparCE(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaDividir(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaMultiplicar(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaSubtrair(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaSomar(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaIgual(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaVirgula(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnTeclaNumeros(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
