using System;

namespace PROYECTO_SANGRE_Y_DOGMA
{
	// Clase padre Personaje: tiene los datos basicos de cada carta y sus get y set
	public class Personaje
	{
		private int id;
		private string nombre;
		private string elemento; // Agua, Tierra, Viento, Fuego
		private int hp;
		private int hpMax;
		private int def;
		private int atk;
		private int ener;
		private int esp;
		private int emp;
		private string historia;

		// Propiedades get y set para encapsular los atributos
		public int Id { get { return id; } set { id = value; } }
		public string Nombre { get { return nombre; } set { nombre = value; } }
		public string Elemento { get { return elemento; } set { elemento = value; } }
		public int HP { get { return hp; } set { hp = value; } }
		public int HPMax { get { return hpMax; } set { hpMax = value; } }
		public int DEF { get { return def; } set { def = value; } }
		public int ATK { get { return atk; } set { atk = value; } }
		public int ENER { get { return ener; } set { ener = value; } }
		public int ESP { get { return esp; } set { esp = value; } }
		public int EMP { get { return emp; } set { emp = value; } }
		public string Historia { get { return historia; } set { historia = value; } }

		// Constructor (HP + DEF + ATK siempre suman 100)
		public Personaje(int _id, string _nombre, string _elemento, int _hp, int _def, int _atk, int _emp)
		{
			Id = _id;
			Nombre = _nombre;
			Elemento = _elemento;
			HP = _hp;
			HPMax = _hp;
			DEF = _def;
			ATK = _atk;
			ENER = 2; // Empieza con 2 de energia
			ESP = 0;  // Empieza con 0 de habilidad especial
			EMP = _emp;
			Historia = "Guerrero registrado en la Arena Elemental para defender el honor de su facción.";
		}

		// Usamos Polimorfismo aqui para el ataque
		public virtual int Atacar(Personaje enemigo)
		{
			// Formula de Calculo (Limites): (ATK * ATK) / (ATK + DEF)
			// Con esta division el dano se reduce si el rival tiene mucha defensa, pero nunca da negativo
			double danoCalculo = (double)(ATK * ATK) / (double)(ATK + enemigo.DEF);

			// Triangulo de debilidades elementales con if/else:
			// Viento vence a Fuego, Fuego vence a Tierra, Tierra vence a Agua, Agua vence a Viento
			if (Elemento == "Viento" && enemigo.Elemento == "Fuego")
			{
				danoCalculo = danoCalculo * 1.5;
			}
			else if (Elemento == "Fuego" && enemigo.Elemento == "Tierra")
			{
				danoCalculo = danoCalculo * 1.5;
			}
			else if (Elemento == "Tierra" && enemigo.Elemento == "Agua")
			{
				danoCalculo = danoCalculo * 1.5;
			}
			else if (Elemento == "Agua" && enemigo.Elemento == "Viento")
			{
				danoCalculo = danoCalculo * 1.5;
			}

			int danoFinal = (int)Math.Round(danoCalculo);
			if (danoFinal < 1) danoFinal = 1;

			enemigo.HP = enemigo.HP - danoFinal;
			if (enemigo.HP < 0) enemigo.HP = 0;

			return danoFinal;
		}

		// Metodo virtual que las clases hijas cambian con override
		public virtual string EjecutarHabilidadEspecial(Personaje enemigo)
		{
			int dano = 15;
			enemigo.HP = enemigo.HP - dano;
			if (enemigo.HP < 0) enemigo.HP = 0;
			return Nombre + " usa habilidad especial (-" + dano + " HP).";
		}

		public virtual Personaje Copiar()
		{
			Personaje copia = new Personaje(Id, Nombre, Elemento, HPMax, DEF, ATK, EMP);
			copia.Historia = Historia;
			return copia;
		}
	}

	// Clase hija 1: Protagonista hereda de Personaje
	public class Protagonista : Personaje
	{
		private string rol;
		public string Rol { get { return rol; } set { rol = value; } }

		public Protagonista(int id, string nombre, string elemento, int hp, int def, int atk, int emp, string _rol)
			: base(id, nombre, elemento, hp, def, atk, emp)
		{
			Rol = _rol;
		}

		// Usamos Polimorfismo (override) para la habilidad especial de cada protagonista
		public override string EjecutarHabilidadEspecial(Personaje enemigo)
		{
			if (Rol == "Guerrero")
			{
				enemigo.HP = enemigo.HP - 25;
				if (enemigo.HP < 0) enemigo.HP = 0;
				return Nombre + " usa Golpe de Hierro (-25 HP fijos).";
			}
			else if (Rol == "Maga")
			{
				int dano = (ATK * 2) - enemigo.DEF;
				if (dano < 12) dano = 12;
				enemigo.HP = enemigo.HP - dano;
				if (enemigo.HP < 0) enemigo.HP = 0;

				HP = HP + 8;
				if (HP > HPMax) HP = HPMax;
				return Nombre + " usa Llamarada Doble (-" + dano + " HP y se cura +8 HP).";
			}
			else if (Rol == "Sanador")
			{
				HP = HP + 15;
				if (HP > HPMax) HP = HPMax;
				DEF = DEF + 4;

				enemigo.HP = enemigo.HP - 12;
				if (enemigo.HP < 0) enemigo.HP = 0;
				return Nombre + " usa Viento Curativo (+15 HP, +4 DEF y quita 12 HP).";
			}
			else if (Rol == "Alquimista")
			{
				enemigo.DEF = enemigo.DEF - 6;
				if (enemigo.DEF < 1) enemigo.DEF = 1;
				ATK = ATK + 4;

				enemigo.HP = enemigo.HP - 16;
				if (enemigo.HP < 0) enemigo.HP = 0;
				return Nombre + " lanza Ácido (-6 DEF rival, +4 ATK y quita 16 HP).";
			}
			else
			{
				if (enemigo.ENER > 0)
				{
					enemigo.ENER = enemigo.ENER - 1;
					ENER = ENER + 1;
				}
				enemigo.HP = enemigo.HP - 20;
				if (enemigo.HP < 0) enemigo.HP = 0;
				return Nombre + " usa Fuego Oscuro (roba 1 ENER y quita 20 HP).";
			}
		}

		public override Personaje Copiar()
		{
			Protagonista copia = new Protagonista(Id, Nombre, Elemento, HPMax, DEF, ATK, EMP, Rol);
			copia.Historia = Historia;
			return copia;
		}
	}

	// Clase hija 2: Duende hereda de Personaje
	public class Duende : Personaje
	{
		private int nivel;
		public int Nivel { get { return nivel; } set { nivel = value; } }

		public Duende(int id, string nombre, string elemento, int hp, int def, int atk, int emp, int _nivel)
			: base(id, nombre, elemento, hp, def, atk, emp)
		{
			Nivel = _nivel;
		}

		// Usamos Polimorfismo (override): el dano del Duende sube segun su nivel
		public override string EjecutarHabilidadEspecial(Personaje enemigo)
		{
			int dano = 10 + (Nivel * 3);
			enemigo.HP = enemigo.HP - dano;
			if (enemigo.HP < 0) enemigo.HP = 0;
			return Nombre + " usa ataque de Nivel " + Nivel + " (-" + dano + " HP).";
		}

		public override Personaje Copiar()
		{
			Duende copia = new Duende(Id, Nombre, Elemento, HPMax, DEF, ATK, EMP, Nivel);
			copia.Historia = Historia;
			return copia;
		}
	}

	// Clase para las 4 cartas de escenario y el Terremoto
	public class CartaEscenario
	{
		public int Id;
		public string Nombre;
		public string Elemento;
		public int UmbralEMP;
		public string Historia;

		public CartaEscenario(int id, string nombre, string elemento, int umbralEmp)
		{
			Id = id;
			Nombre = nombre;
			Elemento = elemento;
			UmbralEMP = umbralEmp;
			Historia = "Campo de batalla elemental donde la facción " + elemento + " recibe ventaja natural.";
		}

		// Da mejora (+4 ATK) si coincide el elemento, o penalizacion (-2 DEF) si no coincide
		public string AplicarBuffNerf(Personaje p)
		{
			if (p.Elemento == Elemento)
			{
				p.ATK = p.ATK + 4;
				return p.Nombre + " gana +4 ATK por el escenario " + Nombre + ".";
			}
			else
			{
				p.DEF = p.DEF - 2;
				if (p.DEF < 1) p.DEF = 1;
				return p.Nombre + " pierde -2 DEF en el escenario " + Nombre + ".";
			}
		}

		// Evento Terremoto: si tiene buena Empatia (EMP >= 50) se cura, si no recibe dano
		public string DispararTerremoto(Personaje p)
		{
			if (p.EMP >= UmbralEMP)
			{
				p.HP = p.HP + 10;
				if (p.HP > p.HPMax) p.HP = p.HPMax;
				p.DEF = p.DEF + 4;
				return "Terremoto: " + p.Nombre + " supera la Empatía (+10 HP y +4 DEF).";
			}
			else
			{
				p.HP = p.HP - 8;
				if (p.HP < 0) p.HP = 0;
				return "Terremoto: " + p.Nombre + " no alcanza la Empatía (-8 HP).";
			}
		}
	}
}
