using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_9.EmailHandler
{
    public interface Iemailsender
    {

        Task SendMailAsync( Message message);
    }
}
