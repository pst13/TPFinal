﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("AGENDAModel", "FK_GrupoContactosSet", "Grupo", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Entity.Grupo), "Contacto", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Entity.Contacto), true)]

#endregion

namespace Entity
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class AGENDAEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto AGENDAEntities usando la cadena de conexión encontrada en la sección 'AGENDAEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public AGENDAEntities() : base("name=AGENDAEntities", "AGENDAEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto AGENDAEntities.
        /// </summary>
        public AGENDAEntities(string connectionString) : base(connectionString, "AGENDAEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto AGENDAEntities.
        /// </summary>
        public AGENDAEntities(EntityConnection connection) : base(connection, "AGENDAEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Contacto> Contacto
        {
            get
            {
                if ((_Contacto == null))
                {
                    _Contacto = base.CreateObjectSet<Contacto>("Contacto");
                }
                return _Contacto;
            }
        }
        private ObjectSet<Contacto> _Contacto;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Grupo> Grupo
        {
            get
            {
                if ((_Grupo == null))
                {
                    _Grupo = base.CreateObjectSet<Grupo>("Grupo");
                }
                return _Grupo;
            }
        }
        private ObjectSet<Grupo> _Grupo;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Contacto. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToContacto(Contacto contacto)
        {
            base.AddObject("Contacto", contacto);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Grupo. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToGrupo(Grupo grupo)
        {
            base.AddObject("Grupo", grupo);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AGENDAModel", Name="Contacto")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Contacto : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Contacto.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad Id.</param>
        /// <param name="nombre">Valor inicial de la propiedad Nombre.</param>
        /// <param name="direccion">Valor inicial de la propiedad Direccion.</param>
        /// <param name="telefono">Valor inicial de la propiedad Telefono.</param>
        /// <param name="grupo_Id">Valor inicial de la propiedad Grupo_Id.</param>
        public static Contacto CreateContacto(global::System.Int32 id, global::System.String nombre, global::System.String direccion, global::System.String telefono, global::System.Int32 grupo_Id)
        {
            Contacto contacto = new Contacto();
            contacto.Id = id;
            contacto.Nombre = nombre;
            contacto.Direccion = direccion;
            contacto.Telefono = telefono;
            contacto.Grupo_Id = grupo_Id;
            return contacto;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, false, "Nombre");
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                OnDireccionChanging(value);
                ReportPropertyChanging("Direccion");
                _Direccion = StructuralObject.SetValidValue(value, false, "Direccion");
                ReportPropertyChanged("Direccion");
                OnDireccionChanged();
            }
        }
        private global::System.String _Direccion;
        partial void OnDireccionChanging(global::System.String value);
        partial void OnDireccionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Telefono
        {
            get
            {
                return _Telefono;
            }
            set
            {
                OnTelefonoChanging(value);
                ReportPropertyChanging("Telefono");
                _Telefono = StructuralObject.SetValidValue(value, false, "Telefono");
                ReportPropertyChanged("Telefono");
                OnTelefonoChanged();
            }
        }
        private global::System.String _Telefono;
        partial void OnTelefonoChanging(global::System.String value);
        partial void OnTelefonoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Grupo_Id
        {
            get
            {
                return _Grupo_Id;
            }
            set
            {
                OnGrupo_IdChanging(value);
                ReportPropertyChanging("Grupo_Id");
                _Grupo_Id = StructuralObject.SetValidValue(value, "Grupo_Id");
                ReportPropertyChanged("Grupo_Id");
                OnGrupo_IdChanged();
            }
        }
        private global::System.Int32 _Grupo_Id;
        partial void OnGrupo_IdChanging(global::System.Int32 value);
        partial void OnGrupo_IdChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AGENDAModel", "FK_GrupoContactosSet", "Grupo")]
        public Grupo Grupo
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Grupo>("AGENDAModel.FK_GrupoContactosSet", "Grupo").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Grupo>("AGENDAModel.FK_GrupoContactosSet", "Grupo").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Grupo> GrupoReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Grupo>("AGENDAModel.FK_GrupoContactosSet", "Grupo");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Grupo>("AGENDAModel.FK_GrupoContactosSet", "Grupo", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AGENDAModel", Name="Grupo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Grupo : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Grupo.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad Id.</param>
        /// <param name="descripcion">Valor inicial de la propiedad Descripcion.</param>
        public static Grupo CreateGrupo(global::System.Int32 id, global::System.String descripcion)
        {
            Grupo grupo = new Grupo();
            grupo.Id = id;
            grupo.Descripcion = descripcion;
            return grupo;
        }

        #endregion

        #region Propiedades simples
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                OnDescripcionChanging(value);
                ReportPropertyChanging("Descripcion");
                _Descripcion = StructuralObject.SetValidValue(value, false, "Descripcion");
                ReportPropertyChanged("Descripcion");
                OnDescripcionChanged();
            }
        }
        private global::System.String _Descripcion;
        partial void OnDescripcionChanging(global::System.String value);
        partial void OnDescripcionChanged();

        #endregion

        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AGENDAModel", "FK_GrupoContactosSet", "Contacto")]
        public EntityCollection<Contacto> Contacto
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Contacto>("AGENDAModel.FK_GrupoContactosSet", "Contacto");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Contacto>("AGENDAModel.FK_GrupoContactosSet", "Contacto", value);
                }
            }
        }

        #endregion

    }

    #endregion

}