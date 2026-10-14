public class Animal { }
public class Vehicle { }
public class SuperHero { }
public class Device { }
public class Appliance { }

public class Penguin : Animal { }
public class Car : Vehicle { }
public class GasolineCar : Vehicle { }
public class Batman : SuperHero { }

// מחלקה זו משמשת רק לדוגמה השגויה שהוצגה בסרטון.
public class FlyingThing { }

/*
הניסיון הבא מהסרטון אינו תקין ב-C#: אין ירושה משתי מחלקות בסיס.
public class Airplane : Vehicle, FlyingThing { }
המחלקה התקינה נשארת במשפחת Vehicle ומממשת את IFlyable.
*/
