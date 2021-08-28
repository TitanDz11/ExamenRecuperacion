using PM2Examen201510020106.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PM2Examen201510020106.ViewModel
{
    public class ListadoViewModel:PersonaModel
    {
        private ObservableCollection<PersonaModel> ListadoPersonas;

        public ObservableCollection<PersonaModel> ListadoPersonas1 
        { 
            get
            {
                if(ListadoPersonas==null)
                {
                    LlenarPersonas();
                }
                return ListadoPersonas;
            }
            set
            {
                ListadoPersonas = value;
            }
        }
        public void LlenarPersonas()
        {
            using(var contexto=new DataContext())
            {
                ObservableCollection<PersonaModel> modelo = new ObservableCollection<PersonaModel>(contexto.Consultar());
                ListadoPersonas = modelo;
            }
            
        }
    }
}
