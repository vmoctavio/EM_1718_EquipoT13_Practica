namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AppGestionEMS.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppGestionEMS.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            string roleTipoUsuario1 = "tipoUsuario1";
            string roleTipoUsuario2 = "tipoUsuario2";
            string roleTipoUsuario3 = "tipoUsuario3";
            AddRole(context, roleTipoUsuario1);
            AddRole(context, roleTipoUsuario2);
            AddRole(context, roleTipoUsuario3);

            AddUser(context, "xxxxxxx", "xxxxxxx", "xx@upm.es", roleTipoUsuario1);
            AddUser(context, "Jessica", "apellidos", "yesica.diaz@upm.es", roleTipoUsuario2);
            AddUser(context, "Carolina", " apellidos ", "carolina.gallardop@upm.es", roleTipoUsuario2);
            AddUser(context, "ficitio1", " apellidos ", "ficticio1@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ficitio2", " apellidos ", "ficticio2@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ficitio3", " apellidos ", "ficticio3@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ficitio4", " apellidos ", "ficticio4@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DIONISIO", "DIEZ GIL", "bi9771@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FIDEL", "ROMERO SOTO", "ia6806@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ELOISA", "GARCIA PARRA", "ky7438@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RUPERTO", "MORA ROMERO", "ln6447@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EULALIO", "BLANCO ORTIZ", "aw1377@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BERNABÉ", "HIDALGO CALVO", "fo912@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HELENIA", "RAMIREZ SANCHEZ", "jj9012@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EULALIO", "SAEZ RAMIREZ", "uq6705@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CAMILA", "CANO VIDAL", "ij5435@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HIGINIO", "CASTRO SANZ", "rf8502@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BLANCA", "SUAREZ DELGADO", "ch8184@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LORENZO", "SOLER ORTIZ", "yu6344@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EVARISTO", "SANTOS ESTEBAN", "uc8702@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RAÚL", "MORENO MARQUEZ", "pe3006@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MARTÍN", "REYES CRESPO", "yi1333@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "REBECA", "RAMOS HERNANDEZ", "ch1740@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HAROLDO", "VARGAS GUTIERREZ", "xx5457@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CASIMIRO", "CRESPO MENDEZ", "re6879@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "WILFREDO", "TORRES MEDINA", "pp133@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FILOMENO", "DIAZ TORRES", "wd8049@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LIDA", "CORTES DELGADO", "jk6855@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROBERTO", "ARIAS SANCHEZ", "rw8521@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CARIDAD", "RODRIGUEZ RAMOS", "mf7003@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DOMINGO", "ROJAS MARTIN", "fd53@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JUSTINIANO", "SANTOS CARMONA", "wc6088@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RAMIRO", "MORALES FLORES", "ew4791@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROSALÍA", "RAMIREZ DOMINGUEZ", "eh7953@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BLANCA", "NIETO PRIETO", "rb2822@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CAMILA", "GALLEGO CASTRO", "xp7053@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CESÁREO", "CARRASCO MOLINA", "iy3204@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MARIANA", "ESTEBAN PEREZ", "lg9330@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROSANA", "ORTEGA WULFRANO", "yo4987@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MALVINA", "FLORES GIMENEZ", "wn5134@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JUDIT", "MEDINA ARIAS", "gw3698@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HUMBERTO", "ORTEGA BLANCO", "jv3832@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JAVIER", "RODRIGUEZ PEÑA", "dl8230@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ÚRSULA", "FERRER CASTRO", "du3531@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BLAS", "CASTILLO GALLEGO", "xe6261@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ULISES", "FERNANDEZ PASCUAL", "gw6792@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EUCLIDES", "SANZ CRESPO", "rl8461@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CAMILA", "HERRERA AGUILAR", "ua1723@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EFRÉN", "PRIETO ARIAS", "wc4883@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JACOBO", "LOPEZ SANTIAGO", "sb8833@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EUSEBIO", "CRUZ GARRIDO", "bz4133@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EULALIA", "VAZQUEZ PEREZ", "tz2494@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HONORIO", "LOPEZ CRESPO", "tg6608@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MIGUEL", "SANZ CARRASCO", "rk9764@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BRUNO", "CASTILLO LEON", "yl9938@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JUDÁ", "MORA DELGADO", "xb9388@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CONRADO", "ARIAS MARIN", "bp7150@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FULVIO", "CABRERA SOTO", "cf113@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FELIPE", "PARRA SOLER", "gu2514@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HUGO", "GOMEZ MARQUEZ", "bw3899@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BENJAMÍN", "AGUILAR HERRERA", "cz3317@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DAGOBERTO", "LOZANO ESTEBAN", "kw1590@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ÚRSULA", "HIDALGO FERNANDEZ", "ka3250@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CIPRIANO", "CANO SANTANA", "yz7333@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROSARIO", "SAEZ MUÑOZ", "wz4863@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "WALDO", "IGLESIAS SERRANO", "eq6958@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CARMELO", "NIETO GIL", "tz3567@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BERNABÉ", "GUERRERO SANCHEZ", "pb4130@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RAMONA", "ORTIZ ORTEGA", "so7665@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CARLOS", "DELGADO GARRIDO", "hm9123@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HUGO", "CASTILLO ROMAN", "ie7914@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JULIO", "PRIETO NUÑEZ", "ew7400@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CLEOPATRA", "SANZ SAEZ", "uq1076@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MAGDALENA", "GALLEGO CALVO", "nk5536@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "REINALDO", "HIDALGO NAVARRO", "no8177@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JUDÁ", "GALLEGO FUENTES", "cg5357@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BERENICE", "GARRIDO MUÑOZ", "sp9944@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BERNABÉ", "SOTO GALLEGO", "iv7557@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CARLA", "LOZANO CABRERA", "pu5534@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RAQUEL", "REYES ROMAN", "xh7446@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MÁXIMO", "MEDINA BENITEZ", "cr7627@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CRISANTO", "PEÑA GUERRERO", "gi6308@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RUPERTO", "CABRERA CASTILLO", "wy3099@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EUGENIO", "BENITEZ GIMENEZ", "vd3174@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FLORIÁN", "LOZANO ORTEGA", "qx852@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CRISTIAN", "MARIN DURAN", "lu2355@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DAGOBERTO", "GALLEGO VIDAL", "oh7522@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BIANCA", "HERNANDEZ MARTINEZ", "ev5058@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JORGE", "LORENZO TORRES", "iv5905@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DORA", "ESTEBAN REYES", "ry6974@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HELI", "PASTOR CALVO", "ju4398@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CARINA", "SOTO PASTOR", "ry6637@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MALVINA", "CRESPO CABALLERO", "fr7084@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "WENCESLAO", "GARRIDO CAMPOS", "qd333@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "URBANA", "CRUZ ORTIZ", "cf2145@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ÚRSULA", "CABRERA ROJAS", "mv6958@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EDMUNDO", "CASTILLO CASTRO", "dl7916@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROSARIO", "MARIN ALVAREZ", "oe77@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CASILDA", "CASTILLO ALVAREZ", "nm7588@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MARTA", "SAEZ LOPEZ", "hi855@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROBERTO", "RAMIREZ WILLIAM", "ax1739@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FLORINDA", "WILLIAM BLANCO", "zx1632@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HILDA", "MARTINEZ LOPEZ", "fq8664@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JAVIER", "SANTIAGO AGUILAR", "qe4352@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RUBÉN", "SANCHEZ NAVARRO", "nq8172@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "WENCESLAO", "HIDALGO CASTRO", "tg1638@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ULFRIDA", "HIDALGO FUENTES", "ne3040@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "REGINA", "GALLARDO SANCHEZ", "hy5958@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CONRADO", "WULSTANA MORA", "zr1577@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RUFINO", "CRESPO HIDALGO", "fi2068@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CLEOPATRA", "ROMERO GOMEZ", "ve7445@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BENITO", "VIDAL GOMEZ", "rp9109@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FERMÍN", "REYES DIEZ", "ki6614@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FLORIDA", "VARGAS CARRASCO", "if5744@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CONSTANTINO", "LOPEZ CABALLERO", "bi6497@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BRUNO", "MORA BLANCO", "qg1552@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ESTEFANÍA", "VAZQUEZ GOMEZ", "mt9727@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RUTH", "MARTINEZ NAVARRO", "kw3316@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BIBIANA", "RODRIGUEZ LOZANO", "qe3776@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CELINA", "NAVARRO GALLEGO", "gy1218@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MIRIAM", "VAZQUEZ SOTO", "vl5876@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ELOY", "LORENZO BLANCO", "xy3147@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JAIME", "FLORES FERNANDEZ", "rv8624@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MAITE", "RODRIGUEZ CARRASCO", "gy2891@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LIDIA", "FERNANDEZ RAMIREZ", "qn3918@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JAQUELINE", "PASTOR HIDALGO", "ap2721@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "WILFREDO", "REYES FERRER", "sd7205@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RENÉ", "FERRER CANO", "fo7303@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DIANA", "GOMEZ DURAN", "eb6180@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FLAVIO", "GIMENEZ JIMENEZ", "zk9544@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ULFRIDA", "PRIETO LEON", "tt4794@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROMEO", "NAVARRO VEGA", "wt2765@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EMILIO", "HIDALGO IGLESIAS", "yv1429@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EULALIA", "HIDALGO GALLEGO", "ur3497@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HAYDEE", "SUAREZ MONTERO", "at8884@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BRUNILDA", "PASCUAL MUÑOZ", "zj4127@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EUGENIA", "RUBIO MARIN", "ch1820@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HOMERO", "NAVARRO NUÑEZ", "lx8242@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DARÍO", "SERRANO CRUZ", "lc788@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DELMIRO", "CASTRO VAZQUEZ", "mq8840@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HORACIO", "MORALES VAZQUEZ", "jw9727@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CELINA", "TORRES WULSTANA", "rw9563@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CRISTINA", "CAMPOS DIAZ", "nh3276@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BRENDA", "MENDEZ CANO", "yf602@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CORNELIO", "NAVARRO WITERICO", "ob376@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROSANA", "SOLER FUENTES", "yn5546@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RUFINO", "BENITEZ RUBIO", "wj3521@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RENATO", "CABALLERO NIETO", "nr6829@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CÉSAR", "IGLESIAS MARTINEZ", "zn6423@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "URBANA", "NUÑEZ PASCUAL", "pt4271@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROBERTO", "NIETO FUENTES", "xz1886@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BERNARDO", "SOLER SOLER", "id5188@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DORA", "CAMPOS FERRER", "xm5881@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RUPERTO", "VICENTE DOMINGUEZ", "ma2665@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ESTEFANÍA", "RUIZ CANO", "sz8296@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MARTÍN", "PASCUAL GUERRERO", "ez2448@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BERENICE", "SANCHEZ PRIETO", "ve2381@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ÚRSULA", "SERRANO ORTEGA", "kx6537@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LUCAS", "CASTILLO CARMONA", "iz9430@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CARLOS", "MENDEZ MENDEZ", "nc4688@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LIDIA", "CASTRO IGLESIAS", "jw7800@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CASIMIRO", "LOPEZ CRESPO", "oc6031@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EVARISTO", "ROMERO GONZALEZ", "oi1641@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "URIEL", "HIDALGO CANO", "jt9027@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BERTA", "ROMERO ROJAS", "ir2796@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "WENDY", "JIMENEZ PEÑA", "hz526@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LUCAS", "JIMENEZ SANZ", "jf3674@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ELENA", "MARTIN SOTO", "su6649@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CORDELIA", "CARRASCO CABALLERO", "nc470@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RUFINO", "RODRIGUEZ TORRES", "ng1148@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MÓNICA", "HIDALGO GIMENEZ", "lj2354@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BENITO", "CASTILLO CALVO", "xt8840@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CLEMENTE", "SOLER RUIZ", "af356@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MÓNICA", "SOTO ESTEBAN", "yo8590@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EMILIO", "CABRERA CABRERA", "so1431@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JULIA", "SOTO DIEZ", "my4882@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HÉCTOR", "WULSTANA SANTOS", "ow5949@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BRUNILDA", "AGUILAR CALVO", "jv8779@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CIPRIANO", "RODRIGUEZ FUENTES", "oa9691@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LEOPOLDO", "CRESPO DURAN", "bh8475@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FLORIÁN", "FUENTES MUÑOZ", "kv4498@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ELISABETH", "VIDAL WILLIAM", "mt5246@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LILIANA", "PEÑA MARIN", "oc7624@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROGELIO", "ESTEBAN PRIETO", "hw950@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROCÍO", "VARGAS SOLER", "km6283@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EUFRASIO", "MARTIN CORTES", "bl4135@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MÓNICA", "PASCUAL MORENO", "rb5518@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LUCIANO", "FERRER SANTIAGO", "iq9452@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JOSEFA", "WULSTANA CASTRO", "jd4425@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BERNARDINA", "SANTOS IBAÑEZ", "qk866@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LUCIANO", "ORTEGA MORENO", "pz1812@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ESPERANZA", "ORTIZ WULFRANO", "po4915@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BERNARDINO", "MEDINA DIAZ", "lm3812@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "Octavio Palomares", "Víctor Manuel", "AH0198@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "REBECA", "LOPEZ GUTIERREZ", "rk4757@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CONCEPCIÓN", "SERRANO DURAN", "eq1008@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HÉCTOR", "GARRIDO TORRES", "hy3356@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LEÓNIDAS", "HIDALGO CRESPO", "sq4991@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MIGUEL", "LOZANO PARRA", "td8939@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JOSEFA", "CABRERA MORENO", "wy6615@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MARCELO", "VAZQUEZ FERNANDEZ", "st168@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JESSICA", "MARTINEZ HIDALGO", "gj8477@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CONSTANTINO", "VEGA WILLIAM", "am212@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FLORIÁN", "CASTRO CRUZ", "gk7107@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CRISTÓBAL", "SUAREZ PEREZ", "xy3685@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RODRIGO", "ALVAREZ VEGA", "tj4260@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MARGARITA", "SANTIAGO MORA", "cr1540@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JUDÁ", "CANO VARGAS", "zf6967@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JUANA", "HERRERO CANO", "hz8641@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EUGENIA", "DOMINGUEZ HERRERA", "vl8188@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CONCEPCIÓN", "VELASCO VELASCO", "wc9871@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MAURO", "MORA CABALLERO", "ao1235@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MOISÉS", "GOMEZ CABRERA", "fu7599@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ELISA", "LOZANO NAVARRO", "xh8130@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CLARA", "RAMOS DIEZ", "mo1920@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROXANA", "ALONSO IGLESIAS", "bv5626@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BERNABÉ", "DELGADO FUENTES", "hm2519@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ERNESTO", "MORENO PEREZ", "ls1971@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CONRADO", "MENDEZ GOMEZ", "st9536@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EUDOXIO", "GOMEZ CALVO", "jk9818@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BELTRÁN", "ALVAREZ CARMONA", "wd1413@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "UNAI", "SOLER PASCUAL", "ne897@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FROILÁN", "SANCHEZ RAMIREZ", "sl3121@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EUCLIDES", "CASTILLO PEREZ", "ei1055@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EUDOXIO", "ARIAS PARRA", "mo8010@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BONIFACIO", "LOPEZ MONTERO", "kq3719@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MÁXIMO", "PASCUAL CRESPO", "hb4952@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JESÚS", "AGUILAR PASTOR", "xz601@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LEÓN", "GONZALEZ GOMEZ", "cq1818@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BLAS", "MENDEZ ESTEBAN", "ho1178@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LETICIA", "CASTRO FERRER", "op8869@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EUFEMIA", "VIDAL ESTEBAN", "pc1155@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BORIS", "MORALES GUERRERO", "st6633@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LIDIA", "SANCHEZ GIMENEZ", "pw1828@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DORA", "DELGADO WITERICO", "du7002@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LINDA", "FERNANDEZ VIDAL", "no8049@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MOISES", "ALONSO VELASCO", "ev1380@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LUCÍA", "MONTERO PASTOR", "ct6159@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DELIA", "FUENTES GUERRERO", "yr3068@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EFRAÍN", "MARTIN VEGA", "lc1901@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROCÍO", "PARRA CASTILLO", "kr489@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ELEONOR", "RAMOS CABALLERO", "im972@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BELINDA", "GUTIERREZ VEGA", "iq6433@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "WILFREDO", "ROMERO LEON", "sc8651@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RODRIGO", "ALONSO SOLER", "hp8013@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DORA", "CARRASCO MORALES", "ua7310@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ERASMO", "VIDAL BRAVO", "jh4625@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CARLA", "GUERRERO GIMENEZ", "jb9010@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MAURO", "JIMENEZ SANZ", "pj9870@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FELIPE", "MARQUEZ RODRIGUEZ", "gx8476@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HERMINIA", "VAZQUEZ DIEZ", "qp9386@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CARMELO", "GUERRERO VICENTE", "fb7312@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ERIC", "GARRIDO SERRANO", "ie5477@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ESMERALDA", "CANO DIEZ", "td754@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JUDIT", "GOMEZ DELGADO", "ot5429@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROMILDO", "SANZ BRAVO", "mz857@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EZEQUIEL", "MARTINEZ FERRER", "uj7791@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CARMEN", "BENITEZ IBAÑEZ", "ls418@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EFRÉN", "ALONSO NUÑEZ", "bk5907@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RENATO", "MORENO VELASCO", "zp2229@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CORNELIO", "DURAN VIDAL", "gi7082@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DINA", "GIL SANCHEZ", "oa3270@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CAMILA", "RUBIO RUIZ", "zh5321@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HORACIO", "RAMOS ALVAREZ", "vv5247@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CASIMIRO", "DIEZ MARTIN", "gc8272@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RAMONA", "MONTERO CABALLERO", "fr7069@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RICARDO", "AGUILAR IBAÑEZ", "jr9125@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EUFEMIO", "ROJAS MARIN", "vf7225@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HAYDEE", "PRIETO ORTEGA", "zi1852@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BERNARDO", "CANO REYES", "yn9787@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MAGALÍ", "SUAREZ GARRIDO", "mf6306@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JACOBO", "IGLESIAS CRUZ", "xd8400@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MACARENA", "REYES GALLARDO", "aa4820@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JESSICA", "DELGADO VAZQUEZ", "et8467@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JAQUELINE", "CASTRO PEÑA", "qw1496@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RAMIRO", "GIMENEZ SUAREZ", "fc5214@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JUSTINIANO", "MORENO GOMEZ", "ck5143@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FROILÁN", "MOLINA LEON", "cb7476@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DAGOBERTO", "ORTIZ WULSTANA", "ql8845@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LEÓN", "WILLIAM CAMPOS", "hi2615@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MARCOS", "ROJAS MARIN", "kj6648@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ESTELA", "CARMONA DIAZ", "kf2967@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MIRTA", "RUBIO GIL", "ci1270@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CARLOS", "FUENTES VELASCO", "xh8355@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CATALINA", "GALLEGO VEGA", "cf9355@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EDGARDO", "MOYA SUAREZ", "yh7617@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LUCIANO", "PASCUAL SUAREZ", "ym764@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FLORENCIO", "HERRERO MORENO", "ik9886@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BONIFACIO", "RUBIO MARTINEZ", "mc5338@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EUFEMIO", "LOPEZ PRIETO", "eg739@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EVA", "SANTOS BLANCO", "me9038@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MIGUEL", "GIL IGLESIAS", "mx8773@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BIANCA", "NAVARRO MONTERO", "wh2069@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MARTA", "GALLARDO SOLER", "gv357@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "REGINA", "SANCHEZ LOZANO", "mc3247@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CLAUDIO", "CARMONA ORTEGA", "il5326@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RUTH", "VARGAS IBAÑEZ", "pf6638@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RAÚL", "HERRERA SOTO", "og8839@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MARÍA", "FUENTES FLORES", "lk5873@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ERICO", "MOYA ORTIZ", "ha2518@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CELSO", "GALLEGO MONTERO", "pa807@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CORA", "WILLIAM WULFRANO", "ei8137@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ULFRIDA", "ORTIZ SANTIAGO", "rw7370@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ERIC", "ROJAS AGUILAR", "rc7460@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROSENDO", "FUENTES CAMPOS", "nz96@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JORGE", "MUÑOZ GONZALEZ", "cb5374@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "EULALIA", "RAMIREZ DURAN", "va4554@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HELENIA", "FERNANDEZ MARTINEZ", "hr7321@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RAMÓN", "GIL BRAVO", "jt3561@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HORACIO", "GARRIDO SOTO", "lb3549@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ELVIRA", "NIETO SANTOS", "nv7714@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BLAS", "CARMONA ORTIZ", "yk6866@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ROQUE", "CALVO PARRA", "gh1106@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "RAFAEL", "GALLEGO RAMIREZ", "ph5236@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "URBANA", "VIDAL HERRERO", "xp7842@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ERICO", "MARIN VICENTE", "dx379@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "FRANCISCO", "CASTILLO JIMENEZ", "lq5727@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ELOISA", "REYES GUERRERO", "ar1108@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JOSEFINA", "PASCUAL HIDALGO", "xi5025@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HERMINIA", "MORALES GIL", "nq8128@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "WALDO", "CRESPO RODRIGUEZ", "ox8107@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "USOA", "GIL PRIETO", "wn6721@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "HELI", "PEÑA DIAZ", "kr1545@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "URANO", "TORRES GOMEZ", "mk6517@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LINDA", "MORENO SOTO", "yd9089@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CARIDAD", "PASCUAL PRIETO", "wo6692@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "CARIDAD", "SAEZ BRAVO", "xz1192@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "LEÓN", "ALVAREZ BRAVO", "as3778@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MARGARITA", "BLANCO GIL", "rl204@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ESPERANZA", "RAMOS ROMERO", "oh7812@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "BRÍGIDA", "HERRERA VEGA", "rd6898@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "WALTER", "IBAÑEZ MARTINEZ", "of1434@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MÓNICA", "CALVO SANCHEZ", "ya1389@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "JULIÁN", "MARTIN MARTINEZ", "dg6438@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DINA", "SAEZ GUTIERREZ", "mf3506@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "DANA", "MUÑOZ CAMPOS", "nr3280@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "MAXIMILIANO", "MUÑOZ MARTINEZ", "xm4117@alumnos.upm.es", roleTipoUsuario3);
            AddUser(context, "ELVIRA", "BRAVO GUERRERO", "vi5362@alumnos.upm.es", roleTipoUsuario3);



        }

        public void AddRole(ApplicationDbContext context, String role)
        {
            IdentityResult IdRoleResult;
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            if (!roleMgr.RoleExists(role))
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = role });
        }

        public void AddUser(ApplicationDbContext context, String name, String surname, String email, String role)
        {
            IdentityResult IdUserResult;
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                Name = name,
                Surname = surname,
                UserName = email,
                Email = email,
            };
            IdUserResult = userMgr.Create(appUser, "123456Aa!");
            //asociar usuario con role
            if (!userMgr.IsInRole(userMgr.FindByEmail(email).Id, role))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail(email).Id, role);
            }
        }

    }
}
