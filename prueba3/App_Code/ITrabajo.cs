using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ITrabajo
{

    [OperationContract]
    int ObtenerModulo(int A, int B);
    // TODO: agregue aquí sus operaciones de servicio
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class Modulo
{
    private int _A, _B;

    public int A
    {
        get
        {
            return _A;
        }

        set
        {
            _A = value;
        }
    }

    public int B
    {
        get
        {
            return _B;
        }

        set
        {
            _B = value;
        }
    }
}
	
