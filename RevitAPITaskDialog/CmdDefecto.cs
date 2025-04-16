using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITaskDialog
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class CmdDefecto : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog mywindow = new TaskDialog("Mi Saludo");
            mywindow.Title = "Hola CRONOS BIM";
            mywindow.TitleAutoPrefix = false;
            mywindow.MainIcon = TaskDialogIcon.TaskDialogIconInformation;
            mywindow.MainInstruction = "Saludos...";
            mywindow.MainContent = "Soy el arquitecto Luis Quispe Galarza" +
                                   " apasionado por el desarrollo de nuevas" +
                                   " tecnologias en la metodologia BIM, me dedico a trabajar en proyectos de" +
                                   " distintas caracteristicas como hospitalarios, educativos, subestacion y entre" +
                                   " otros. Tambien me desempeño en desarrollar aplicaciones tipo Addin en el" +
                                   " entorno de desarrollo de Revit."+
                                   "este contenido es de uso de ejemplo"+
                                   "este contenido es de uso de mero ejemplo";
            mywindow.FooterText = "Copyright (C) 2023 by Cronos Arquitectura e Ingenieria";
            mywindow.ExpandedContent = "Si necesita saber mas sobre el aplicativo puede revisar los videos " +
                                        "dentro de nuestro canal de Youtube CronosBim o comunicarse al numero de celular 988706396";
            mywindow.VerificationText = "En Cronos transformamos proyectos con innovación";
            mywindow.CommonButtons = TaskDialogCommonButtons.Cancel |
                                    TaskDialogCommonButtons.Retry |
                                    TaskDialogCommonButtons.None;
            mywindow.Show();
            return Result.Succeeded;
        }
    }
}
