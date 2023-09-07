using StorageSpace;

Flash op = new("Flash card","model",10);
op.PrintDeviceinfo();

DVD op2 = new("DVD name","DVD model",3,1);
op2.PrintDeviceinfo();
op2.copy(2.5);
Console.Write(op2.freeMemoryInMB());