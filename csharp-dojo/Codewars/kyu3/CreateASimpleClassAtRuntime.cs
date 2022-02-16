using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;

namespace Codewars.kyu3
{

    /*
     * https://www.codewars.com/kata/589394ae1a880832e2000092/train/csharp
     * 
     * #Create A Class at Runtime

        Your method will accept as arguments a string containing the class name, a dictionary String -> Type containing the properties, and a ref to the actual Type of the class after it has been created.
        You should check if a class already exists in the same assembly and return false if so, also you should make sure to create every class in the same assembly, let's call it "RuntimeAssembly", namespace is optional, but the class names will be passed to your method without any namespace.

        The properties of each of your classes will then be accessed and modified normally, e.g:

        properties = new Dictionary<string, Type> { { "AString", typeof(string) } };    
        Kata.DefineClass("SimpleClass", properties, ref myType);    
        myInstance = CreateInstance(myType);    
        myInstance.AString = "Hi";   

        You will pass the kata if none of these operations throw an exception, and if the values are actually changed.

        Happy coding

     * 
     * 
     */
    public class CreateASimpleClassAtRuntime
    {

        public static ModuleBuilder moduleBuilder = null;

        public static bool DefineClass(string className, Dictionary<string, Type> properties, ref Type actualType)
        {
            if (moduleBuilder == null)
            {
                AssemblyName assName = new AssemblyName("RuntimeAssembly");
                AssemblyBuilder abuilder = AssemblyBuilder.DefineDynamicAssembly(assName, AssemblyBuilderAccess.Run);
                moduleBuilder = abuilder.DefineDynamicModule(assName.Name);
            }

            if (moduleBuilder.GetType(className) != null)
                return false;

            TypeBuilder typeBuilder = moduleBuilder.DefineType(className, TypeAttributes.Public);

            MethodAttributes methodAttribs = MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig;

            foreach(KeyValuePair<string,Type> keyValuePair in properties)
            {
                FieldBuilder fieldBuilder = typeBuilder.DefineField("_" + keyValuePair.Key, keyValuePair.Value, FieldAttributes.Private);
                PropertyBuilder propBuilder= typeBuilder.DefineProperty(keyValuePair.Key,
                    PropertyAttributes.HasDefault,
                    keyValuePair.Value,
                    null);

                MethodBuilder mbGetAccessor = typeBuilder.DefineMethod("get_" + keyValuePair.Key, methodAttribs, keyValuePair.Value, Type.EmptyTypes);
                ILGenerator ilGet = mbGetAccessor.GetILGenerator();
                ilGet.Emit(OpCodes.Ldarg_0);
                ilGet.Emit(OpCodes.Ldfld, fieldBuilder);
                ilGet.Emit(OpCodes.Ret);

                MethodBuilder mbSetAccessor = typeBuilder.DefineMethod("set_" + keyValuePair.Key, methodAttribs, null, new Type[] {keyValuePair.Value});
                ILGenerator ilSet = mbSetAccessor.GetILGenerator();
                ilSet.Emit(OpCodes.Ldarg_0);
                ilSet.Emit(OpCodes.Ldarg_1);
                ilSet.Emit(OpCodes.Stfld, fieldBuilder);
                ilSet.Emit(OpCodes.Ret);

                propBuilder.SetGetMethod(mbGetAccessor);
                propBuilder.SetSetMethod(mbSetAccessor);
            }

            actualType = typeBuilder.CreateType();

            return true;
        }
    }
}
