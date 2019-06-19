/*!
 * \copyright 2016 JSC "Rudnev-Shilyaev"
 * 
 * \file LA-2USB_StartStop.cs
 * \date 20.06.2016
 * 
 * \~english
 * \brief
 * Data acquisition in "Start-Stop" mode for LA-2USB device
 * 
 * \~russian
 * \brief
 * Сбор данных в режиме "Старт-Стоп" для устройства ЛА-2USB
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using RshCSharpWrapper;
using RshCSharpWrapper.RshDevice;


//################################# СБОР ДАННЫХ В РЕЖИМЕ СТАРТ-СТОП #################################

namespace StartStop
{
    class StartStop
    {
        [STAThread]
        static int Main(string[] args)
        {
            frmMain mainF = new frmMain();
            mainF.ShowDialog();
            return 0;
        }
    }
}