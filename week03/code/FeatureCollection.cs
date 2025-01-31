using System.ComponentModel;
public class FeatureCollection
{
    public List<Feature> features {get;set;}
}

public class Feature {
    public Properties properties {get; set;}
}

public class Properties {
    public decimal mag {get;set;}
    public string place {get;set;}
}
