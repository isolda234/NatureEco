using NatureEco.CarouselItem;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Graphics.ImageDecoder;

namespace NatureEco.Views
{


    public partial class News :ContentPage
    {
        

        ObservableCollection<itemcarousel> ambientes;
        public News()
            {
           
                InitializeComponent();
            ambientes = new ObservableCollection<itemcarousel>
            {
                
                new itemcarousel{ Name="Deforestation", Descricao="A desflorestação foi visto durante muito anos como impulsionadora do desenvolvimento Economico, contudo esta tem tido grandes impactos tais como:" +
                "Aumento efeito da estufa" +
                "Erosão dos Solos" +
                "Diminuição da Biodiversidade", Imagem="desflorestacao.jpg"} ,
                  new itemcarousel{ Name="Poluição", Descricao="Poluição pode ser definida como o resultado de atividades antrópicas ou meios naturais que desencadeiam a degradação do meio ambiente," +
                  " das quais pode ter consequencias tais como:" +
                  "Problema de Saúde(doenças respiratorias, AVC)" +
                  "", Imagem="poluicao.jpg"},
                   new itemcarousel{ Name="Poluição", Descricao="Poluição pode ser definida como o resultado de atividades antrópicas ou meios naturais que desencadeiam a degradação do meio ambiente," +
                  " das quais pode ter consequencias tais como:" +
                  "Problema de Saúde(doenças respiratorias, AVC)" +
                  "", Imagem="desflorestacao.jpg"},
                    new itemcarousel{ Name="Poluição", Descricao="Poluição pode ser definida como o resultado de atividades antrópicas ou meios naturais que desencadeiam a degradação do meio ambiente," +
                  " das quais pode ter consequencias tais como:" +
                  "Problema de Saúde(doenças respiratorias, AVC)" +
                  "", Imagem="poluicao.jpg"},
            };
            

           
         
           }
    }
}