namespace StorageSpace;
    public abstract class Storage{
        public string ? media_name {get;set;}
        public string ? model {get;set;}
        public double ? speed {get;set;}
        public double ? storage {get;set;}
        public double ? used_storage {get;set;} = 0.0;
        public Storage(string media_n, string model_, double speed_, double _storage) {
            media_name = media_n;
            model = model_;
            speed = speed_;
            storage = _storage;
        }
        public virtual void PrintDeviceinfo() {
            Console.WriteLine($"Media name: {media_name}\n model: {model}\n speed: {speed}mb/s\n storage: {storage} GB");
        }
        public double freeMemoryInMB() {
            return (double)((storage * 1000) - (used_storage * 1000));
        }
        private void calculateTime(double GB) {
            double mb_ = GB*1000;
            int seconds = Convert.ToInt32(mb_ / speed);
            int min = Convert.ToInt32(seconds/60);
            Console.WriteLine($"{min} deqiqe cekdi yuklenmeyi");
        }
        public void copy(double GB) {
            if((storage*1000) >= (GB*1000)) {
                used_storage += GB; 
                calculateTime(GB);
            } else throw new Exception("Yerlesmedi daha kici fayl yuklemeyi cehd edin");
        }
    }
    public class Flash : Storage
    {
    public Flash(string name, string model, double memory) : base(name, model, 3.0, memory)
    {
        
    }
    public override void PrintDeviceinfo()
    {
            Console.WriteLine("This is Flash: ");
            base.PrintDeviceinfo();       
    }
}

public class DVD : Storage
{
    public double ReadWriteSpeed { get; set; }
    public string Type { get; set; }
    public DVD(string name, string model, double memory, double readWriteSpeed) : base(name, model, readWriteSpeed, memory)
    {

    }
    public override void PrintDeviceinfo()
    {
            Console.WriteLine("This is DVD: ");
            base.PrintDeviceinfo();       
    }
}
public class HDD : Storage
{
    public HDD(string name, string model, double memory) : base(name, model, 2.0, memory)
    {
        
    }
    public override void PrintDeviceinfo()
    {
            Console.WriteLine("This is HDD: ");
            base.PrintDeviceinfo();       
    }
}

