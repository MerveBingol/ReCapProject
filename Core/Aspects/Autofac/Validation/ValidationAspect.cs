using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            // Reflection
            var validator = (IValidator)Activator.CreateInstance(_validatorType);// o CarValidator ün bir instance sını oluştur.
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];//CarValidator ın çalışma tipini bul (CarValidator:AbstarctValidator<Car>)
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//Validator ın tipine(örn: Car) eşit olan parametreleri bul
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);// ValidationTool u kullanarak Validate et.
            }
        }
    }
}
