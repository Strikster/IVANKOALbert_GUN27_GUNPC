using System;

public class Unit
{
   
    public string Name { get; }
    private float health; 
    public int Damage { get; } 
    private float armor; 


    public Unit() : this("Unknown Unit") 
    {
       
    }

    public Unit(string name) 
    {
        Name = name; 

        health = 100f; 
        Damage = 5;    
        armor = 0.6f;  
    }


    public float Health
    {
        get { return health; }
    }

   
    public float GetRealHealth()
    {
        return Health * (1f + Armor);
    }

   
    public float Armor
    {
        get { return armor; }
    }

 
    public bool SetDamage(float value)
    {
        health -= value * Armor; 

        
        return health <= 0f;
    }
}