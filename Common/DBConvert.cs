using System.Reflection;

namespace JKMEWApp.Tools
{
    public class DBConvert
    {
        public static TBusiness ConvertEntityToBusiness<TEntity, TBusiness>(TEntity entityModel)
        where TEntity : class
        where TBusiness : class, new()
        {
            var businessModel = new TBusiness();
            var entityType = typeof(TEntity);
            var businessType = typeof(TBusiness);

            // 获取实体模型中的所有属性
            var entityProperties = entityType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var entityProperty in entityProperties)
            {
                // 判断业务模型中是否存在同名属性
                var businessProperty = businessType.GetProperty(entityProperty.Name, BindingFlags.Public | BindingFlags.Instance);
                // 如果存在同名属性，并且属性值类型一致，则将实体模型中的属性值赋值给业务模型中的属性
                if (businessProperty != null && businessProperty.PropertyType == entityProperty.PropertyType)
                {
                    var entityValue = entityProperty.GetValue(entityModel);
                    if (entityValue != null)
                    {
                        businessProperty.SetValue(businessModel, entityValue);
                    }
                }
            }

            return businessModel;
        }

        public static TEntity ConvertBusinessToEntity<TEntity, TBusiness>(TBusiness businessModel)
        where TEntity : class, new()
        where TBusiness : class
        {
            var entityModel = new TEntity();
            var entityType = typeof(TEntity);
            var businessType = typeof(TBusiness);

            // 获取实体模型中的所有属性
            var entityProperties = entityType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var entityProperty in entityProperties)
            {
                // 判断业务模型中是否存在同名属性
                var businessProperty = businessType.GetProperty(entityProperty.Name, BindingFlags.Public | BindingFlags.Instance);
                // 如果存在同名属性，并且属性值类型一致，则将业务模型中的属性值赋值给实体模型中的属性
                if (businessProperty != null && businessProperty.PropertyType == entityProperty.PropertyType)
                {
                    var businessValue = businessProperty.GetValue(businessModel);
                    if (businessValue != null)
                    {
                        entityProperty.SetValue(entityModel, businessValue);
                    }
                }
            }
            return entityModel;
        }
    }
}