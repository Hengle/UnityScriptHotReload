using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptHotReload
{
    /// <summary>
    /// ���ͺ�����HookWrapper(Patcherʹ�ã������ֶ����)
    /// </summary>
    public class GenericMethodIndexAttribute : Attribute
    {
        public int index;
    }

    /// <summary>
    /// ���ͺ������ɵ�wrapper������(Patcherʹ�ã������ֶ����)
    /// </summary>
    public class GenericMethodWrapperAttribute : Attribute
    {
        /// <summary>
        /// ����������� HookWrapperGenericAttribute ��ͬ�����Զ��һ
        /// </summary>
        public int index;
        /// <summary>
        /// ���������ķ������͵����Ͳ����б� + ���ͷ��������Ͳ����б�
        /// </summary>
        public Type[] typeGenArgs;
    }
}
