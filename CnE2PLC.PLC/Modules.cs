using System;
using System.Collections.Generic;
using System.Text;

namespace CnE2PLC.PLC
{
    internal class Module
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CatalogNumber { get; set; } = string.Empty;
        public string Vendor { get; set; } = string.Empty;
        public string ProductType { get; set; } = string.Empty;
        public string ProductCode { get; set; } = string.Empty;
        public int Major { get; set; } = 0;
        public int Minor { get; set; } = 0;
        public string ParentModule { get; set; } = string.Empty;
        public int ParentModPortId { get; set; } = 0;
        public bool Inhibited { get; set; } = false;
        public bool MajorFault { get; set; } = false;
        public EKey EKey { get; set; } = new EKey();

    }


    internal class EKey {
        public EKeyStates State { get; set; } = EKeyStates.CompatibleModule;

        public enum EKeyStates
        {
            ExactMatch,
            CompatibleModule,
            Disabled,
        }
    }


    internal class Port {
        public int Id { get; set; } = 0;
        public string Address { get; set; } = string.Empty;
        public PortTypes Type { get; set; } = PortTypes.None;
        public bool Upstream { get; set; } = false;
        public Bus Bus { get; set; } = new Bus();

        public enum PortTypes
        {
            Ethernet,
            Compact,
            ICP,
            Flex,
            None
        }

    }

    internal class Bus {
        public int Size { get; set; } = 0;
    }   

}
