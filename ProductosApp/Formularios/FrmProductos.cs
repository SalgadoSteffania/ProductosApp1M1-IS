using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Formularios
{
    public partial class FrmProductos : Form
    {
        private IProductoService productoService;
        public FrmProductos(IProductoService productoService)
        {
            this.productoService = productoService;
            InitializeComponent();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.PModel = productoService;
            frmProducto.ShowDialog();

            rtbProductView.Text = productoService.GetProductosAsJson();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(cmbFinderType.SelectedIndex == 0)
            {

                Producto Tempo = productoService.AsignarValoresTotalPONDERADO();
                rtbProductView.Text = " ";

                if(Tempo== null)
                {
                    rtbProductView.Text = "No se encuentra ningun elemento ";
                }
                else
                {
                    rtbProductView.Text = $"Valor :{Tempo.AsignarValoresTotalPONDERADO},{Tempo.AsignarValoresUnidadPONDERADO},{Tempo.TotalInventarioPONDERADO}";

                }

            }
            if (cmbFinderType.SelectedIndex == 1)
            {















            }
            if (cmbFinderType.SelectedIndex == 2)
            {
















            }
            if (cmbFinderType.SelectedIndex == 3)
            {











            }

        }
    }
}
