// **********************************************************************
//
// Copyright (c) 2003-2009 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// ICE_LICENSE file included in this distribution.
//
// **********************************************************************

// Ice version 3.3.1
// Generated from file `idht.ice'

#if __MonoCS__

using _System = System;
using _Microsoft = Microsoft;
#else

using _System = global::System;
using _Microsoft = global::Microsoft;
#endif

namespace IDHT
{
    public struct range
    {
        #region Slice data members

        public int min;

        public int max;

        #endregion

        #region Constructor

        public range(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        #endregion

        #region Object members

        public override int GetHashCode()
        {
            int h__ = 0;
            h__ = 5 * h__ + min.GetHashCode();
            h__ = 5 * h__ + max.GetHashCode();
            return h__;
        }

        public override bool Equals(object other__)
        {
            if(!(other__ is range))
            {
                return false;
            }
            range o__ = (range)other__;
            if(!min.Equals(o__.min))
            {
                return false;
            }
            if(!max.Equals(o__.max))
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Comparison members

        public static bool operator==(range lhs__, range rhs__)
        {
            return Equals(lhs__, rhs__);
        }

        public static bool operator!=(range lhs__, range rhs__)
        {
            return !Equals(lhs__, rhs__);
        }

        #endregion

        #region Marshalling support

        public void write__(IceInternal.BasicStream os__)
        {
            os__.writeInt(min);
            os__.writeInt(max);
        }

        public void read__(IceInternal.BasicStream is__)
        {
            min = is__.readInt();
            max = is__.readInt();
        }

        #endregion
    }

    public class keyvaluepair : _System.ICloneable
    {
        #region Slice data members

        public string key;

        public string value;

        #endregion

        #region Constructors

        public keyvaluepair()
        {
        }

        public keyvaluepair(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        #endregion

        #region ICloneable members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion

        #region Object members

        public override int GetHashCode()
        {
            int h__ = 0;
            if(key != null)
            {
                h__ = 5 * h__ + key.GetHashCode();
            }
            if(value != null)
            {
                h__ = 5 * h__ + value.GetHashCode();
            }
            return h__;
        }

        public override bool Equals(object other__)
        {
            if(object.ReferenceEquals(this, other__))
            {
                return true;
            }
            if(other__ == null)
            {
                return false;
            }
            if(GetType() != other__.GetType())
            {
                return false;
            }
            keyvaluepair o__ = (keyvaluepair)other__;
            if(key == null)
            {
                if(o__.key != null)
                {
                    return false;
                }
            }
            else
            {
                if(!key.Equals(o__.key))
                {
                    return false;
                }
            }
            if(value == null)
            {
                if(o__.value != null)
                {
                    return false;
                }
            }
            else
            {
                if(!value.Equals(o__.value))
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Comparison members

        public static bool operator==(keyvaluepair lhs__, keyvaluepair rhs__)
        {
            return Equals(lhs__, rhs__);
        }

        public static bool operator!=(keyvaluepair lhs__, keyvaluepair rhs__)
        {
            return !Equals(lhs__, rhs__);
        }

        #endregion

        #region Marshalling support

        public void write__(IceInternal.BasicStream os__)
        {
            os__.writeString(key);
            os__.writeString(value);
        }

        public void read__(IceInternal.BasicStream is__)
        {
            key = is__.readString();
            value = is__.readString();
        }

        #endregion
    }

    public class nodeConf : _System.ICloneable
    {
        #region Slice data members

        public string nodeId;

        public string parentNode;

        public int min;

        public int max;

        public IDHT.keyvaluepair[] elems;

        #endregion

        #region Constructors

        public nodeConf()
        {
        }

        public nodeConf(string nodeId, string parentNode, int min, int max, IDHT.keyvaluepair[] elems)
        {
            this.nodeId = nodeId;
            this.parentNode = parentNode;
            this.min = min;
            this.max = max;
            this.elems = elems;
        }

        #endregion

        #region ICloneable members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion

        #region Object members

        public override int GetHashCode()
        {
            int h__ = 0;
            if(nodeId != null)
            {
                h__ = 5 * h__ + nodeId.GetHashCode();
            }
            if(parentNode != null)
            {
                h__ = 5 * h__ + parentNode.GetHashCode();
            }
            h__ = 5 * h__ + min.GetHashCode();
            h__ = 5 * h__ + max.GetHashCode();
            if(elems != null)
            {
                h__ = 5 * h__ + IceUtilInternal.Arrays.GetHashCode(elems);
            }
            return h__;
        }

        public override bool Equals(object other__)
        {
            if(object.ReferenceEquals(this, other__))
            {
                return true;
            }
            if(other__ == null)
            {
                return false;
            }
            if(GetType() != other__.GetType())
            {
                return false;
            }
            nodeConf o__ = (nodeConf)other__;
            if(nodeId == null)
            {
                if(o__.nodeId != null)
                {
                    return false;
                }
            }
            else
            {
                if(!nodeId.Equals(o__.nodeId))
                {
                    return false;
                }
            }
            if(parentNode == null)
            {
                if(o__.parentNode != null)
                {
                    return false;
                }
            }
            else
            {
                if(!parentNode.Equals(o__.parentNode))
                {
                    return false;
                }
            }
            if(!min.Equals(o__.min))
            {
                return false;
            }
            if(!max.Equals(o__.max))
            {
                return false;
            }
            if(elems == null)
            {
                if(o__.elems != null)
                {
                    return false;
                }
            }
            else
            {
                if(!IceUtilInternal.Arrays.Equals(elems, o__.elems))
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Comparison members

        public static bool operator==(nodeConf lhs__, nodeConf rhs__)
        {
            return Equals(lhs__, rhs__);
        }

        public static bool operator!=(nodeConf lhs__, nodeConf rhs__)
        {
            return !Equals(lhs__, rhs__);
        }

        #endregion

        #region Marshalling support

        public void write__(IceInternal.BasicStream os__)
        {
            os__.writeString(nodeId);
            os__.writeString(parentNode);
            os__.writeInt(min);
            os__.writeInt(max);
            if(elems == null)
            {
                os__.writeSize(0);
            }
            else
            {
                os__.writeSize(elems.Length);
                for(int ix__ = 0; ix__ < elems.Length; ++ix__)
                {
                    (elems[ix__] == null ? new IDHT.keyvaluepair() : elems[ix__]).write__(os__);
                }
            }
        }

        public void read__(IceInternal.BasicStream is__)
        {
            nodeId = is__.readString();
            parentNode = is__.readString();
            min = is__.readInt();
            max = is__.readInt();
            {
                int szx__ = is__.readSize();
                is__.startSeq(szx__, 2);
                elems = new IDHT.keyvaluepair[szx__];
                for(int ix__ = 0; ix__ < szx__; ++ix__)
                {
                    elems[ix__] = new IDHT.keyvaluepair();
                    elems[ix__].read__(is__);
                    is__.checkSeq();
                    is__.endElement();
                }
                is__.endSeq(szx__);
            }
        }

        #endregion
    }

    public interface DHTNode : Ice.Object, DHTNodeOperations_, DHTNodeOperationsNC_
    {
    }
}

namespace IDHT
{
    public interface DHTNodePrx : Ice.ObjectPrx
    {
        IDHT.nodeConf newConnected(string id);
        IDHT.nodeConf newConnected(string id, _System.Collections.Generic.Dictionary<string, string> context__);

        void slaveDisconnected(string id, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges);
        void slaveDisconnected(string id, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, _System.Collections.Generic.Dictionary<string, string> context__);

        void masterDisconnected(string connectTo, IDHT.range subtree, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges);
        void masterDisconnected(string connectTo, IDHT.range subtree, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, _System.Collections.Generic.Dictionary<string, string> context__);

        string searchDHT(string key);
        string searchDHT(string key, _System.Collections.Generic.Dictionary<string, string> context__);

        void insertDHT(string key, string val);
        void insertDHT(string key, string val, _System.Collections.Generic.Dictionary<string, string> context__);
    }
}

namespace IDHT
{
    public interface DHTNodeOperations_
    {
        IDHT.nodeConf newConnected(string id, Ice.Current current__);

        void slaveDisconnected(string id, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, Ice.Current current__);

        void masterDisconnected(string connectTo, IDHT.range subtree, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, Ice.Current current__);

        string searchDHT(string key, Ice.Current current__);

        void insertDHT(string key, string val, Ice.Current current__);
    }

    public interface DHTNodeOperationsNC_
    {
        IDHT.nodeConf newConnected(string id);

        void slaveDisconnected(string id, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges);

        void masterDisconnected(string connectTo, IDHT.range subtree, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges);

        string searchDHT(string key);

        void insertDHT(string key, string val);
    }
}

namespace IDHT
{
    public sealed class valuesHelper
    {
        public static void write(IceInternal.BasicStream os__, IDHT.keyvaluepair[] v__)
        {
            if(v__ == null)
            {
                os__.writeSize(0);
            }
            else
            {
                os__.writeSize(v__.Length);
                for(int ix__ = 0; ix__ < v__.Length; ++ix__)
                {
                    (v__[ix__] == null ? new IDHT.keyvaluepair() : v__[ix__]).write__(os__);
                }
            }
        }

        public static IDHT.keyvaluepair[] read(IceInternal.BasicStream is__)
        {
            IDHT.keyvaluepair[] v__;
            {
                int szx__ = is__.readSize();
                is__.startSeq(szx__, 2);
                v__ = new IDHT.keyvaluepair[szx__];
                for(int ix__ = 0; ix__ < szx__; ++ix__)
                {
                    v__[ix__] = new IDHT.keyvaluepair();
                    v__[ix__].read__(is__);
                    is__.checkSeq();
                    is__.endElement();
                }
                is__.endSeq(szx__);
            }
            return v__;
        }
    }

    public sealed class rangesHelper
    {
        public static void write(IceInternal.BasicStream os__, IDHT.range[] v__)
        {
            if(v__ == null)
            {
                os__.writeSize(0);
            }
            else
            {
                os__.writeSize(v__.Length);
                for(int ix__ = 0; ix__ < v__.Length; ++ix__)
                {
                    v__[ix__].write__(os__);
                }
            }
        }

        public static IDHT.range[] read(IceInternal.BasicStream is__)
        {
            IDHT.range[] v__;
            {
                int szx__ = is__.readSize();
                is__.checkFixedSeq(szx__, 8);
                v__ = new IDHT.range[szx__];
                for(int ix__ = 0; ix__ < szx__; ++ix__)
                {
                    v__[ix__].read__(is__);
                }
            }
            return v__;
        }
    }

    public sealed class confsHelper
    {
        public static void write(IceInternal.BasicStream os__, IDHT.nodeConf[] v__)
        {
            if(v__ == null)
            {
                os__.writeSize(0);
            }
            else
            {
                os__.writeSize(v__.Length);
                for(int ix__ = 0; ix__ < v__.Length; ++ix__)
                {
                    (v__[ix__] == null ? new IDHT.nodeConf() : v__[ix__]).write__(os__);
                }
            }
        }

        public static IDHT.nodeConf[] read(IceInternal.BasicStream is__)
        {
            IDHT.nodeConf[] v__;
            {
                int szx__ = is__.readSize();
                is__.startSeq(szx__, 11);
                v__ = new IDHT.nodeConf[szx__];
                for(int ix__ = 0; ix__ < szx__; ++ix__)
                {
                    v__[ix__] = new IDHT.nodeConf();
                    v__[ix__].read__(is__);
                    is__.checkSeq();
                    is__.endElement();
                }
                is__.endSeq(szx__);
            }
            return v__;
        }
    }

    public sealed class DHTNodePrxHelper : Ice.ObjectPrxHelperBase, DHTNodePrx
    {
        #region Synchronous operations

        public void insertDHT(string key, string val)
        {
            insertDHT(key, val, null, false);
        }

        public void insertDHT(string key, string val, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            insertDHT(key, val, context__, true);
        }

        private void insertDHT(string key, string val, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
        {
            if(explicitContext__ && context__ == null)
            {
                context__ = emptyContext_;
            }
            int cnt__ = 0;
            while(true)
            {
                Ice.ObjectDel_ delBase__ = null;
                try
                {
                    delBase__ = getDelegate__(false);
                    DHTNodeDel_ del__ = (DHTNodeDel_)delBase__;
                    del__.insertDHT(key, val, context__);
                    return;
                }
                catch(IceInternal.LocalExceptionWrapper ex__)
                {
                    handleExceptionWrapper__(delBase__, ex__, null);
                }
                catch(Ice.LocalException ex__)
                {
                    handleException__(delBase__, ex__, null, ref cnt__);
                }
            }
        }

        public void masterDisconnected(string connectTo, IDHT.range subtree, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges)
        {
            masterDisconnected(connectTo, subtree, newRanges, childRanges, null, false);
        }

        public void masterDisconnected(string connectTo, IDHT.range subtree, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            masterDisconnected(connectTo, subtree, newRanges, childRanges, context__, true);
        }

        private void masterDisconnected(string connectTo, IDHT.range subtree, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
        {
            if(explicitContext__ && context__ == null)
            {
                context__ = emptyContext_;
            }
            int cnt__ = 0;
            while(true)
            {
                Ice.ObjectDel_ delBase__ = null;
                try
                {
                    delBase__ = getDelegate__(false);
                    DHTNodeDel_ del__ = (DHTNodeDel_)delBase__;
                    del__.masterDisconnected(connectTo, subtree, newRanges, childRanges, context__);
                    return;
                }
                catch(IceInternal.LocalExceptionWrapper ex__)
                {
                    handleExceptionWrapper__(delBase__, ex__, null);
                }
                catch(Ice.LocalException ex__)
                {
                    handleException__(delBase__, ex__, null, ref cnt__);
                }
            }
        }

        public IDHT.nodeConf newConnected(string id)
        {
            return newConnected(id, null, false);
        }

        public IDHT.nodeConf newConnected(string id, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            return newConnected(id, context__, true);
        }

        private IDHT.nodeConf newConnected(string id, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
        {
            if(explicitContext__ && context__ == null)
            {
                context__ = emptyContext_;
            }
            int cnt__ = 0;
            while(true)
            {
                Ice.ObjectDel_ delBase__ = null;
                try
                {
                    checkTwowayOnly__("newConnected");
                    delBase__ = getDelegate__(false);
                    DHTNodeDel_ del__ = (DHTNodeDel_)delBase__;
                    return del__.newConnected(id, context__);
                }
                catch(IceInternal.LocalExceptionWrapper ex__)
                {
                    handleExceptionWrapper__(delBase__, ex__, null);
                }
                catch(Ice.LocalException ex__)
                {
                    handleException__(delBase__, ex__, null, ref cnt__);
                }
            }
        }

        public string searchDHT(string key)
        {
            return searchDHT(key, null, false);
        }

        public string searchDHT(string key, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            return searchDHT(key, context__, true);
        }

        private string searchDHT(string key, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
        {
            if(explicitContext__ && context__ == null)
            {
                context__ = emptyContext_;
            }
            int cnt__ = 0;
            while(true)
            {
                Ice.ObjectDel_ delBase__ = null;
                try
                {
                    checkTwowayOnly__("searchDHT");
                    delBase__ = getDelegate__(false);
                    DHTNodeDel_ del__ = (DHTNodeDel_)delBase__;
                    return del__.searchDHT(key, context__);
                }
                catch(IceInternal.LocalExceptionWrapper ex__)
                {
                    handleExceptionWrapper__(delBase__, ex__, null);
                }
                catch(Ice.LocalException ex__)
                {
                    handleException__(delBase__, ex__, null, ref cnt__);
                }
            }
        }

        public void slaveDisconnected(string id, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges)
        {
            slaveDisconnected(id, newRanges, childRanges, null, false);
        }

        public void slaveDisconnected(string id, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            slaveDisconnected(id, newRanges, childRanges, context__, true);
        }

        private void slaveDisconnected(string id, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
        {
            if(explicitContext__ && context__ == null)
            {
                context__ = emptyContext_;
            }
            int cnt__ = 0;
            while(true)
            {
                Ice.ObjectDel_ delBase__ = null;
                try
                {
                    delBase__ = getDelegate__(false);
                    DHTNodeDel_ del__ = (DHTNodeDel_)delBase__;
                    del__.slaveDisconnected(id, newRanges, childRanges, context__);
                    return;
                }
                catch(IceInternal.LocalExceptionWrapper ex__)
                {
                    handleExceptionWrapper__(delBase__, ex__, null);
                }
                catch(Ice.LocalException ex__)
                {
                    handleException__(delBase__, ex__, null, ref cnt__);
                }
            }
        }

        #endregion

        #region Checked and unchecked cast operations

        public static DHTNodePrx checkedCast(Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            DHTNodePrx r = b as DHTNodePrx;
            if((r == null) && b.ice_isA("::IDHT::DHTNode"))
            {
                DHTNodePrxHelper h = new DHTNodePrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static DHTNodePrx checkedCast(Ice.ObjectPrx b, _System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            DHTNodePrx r = b as DHTNodePrx;
            if((r == null) && b.ice_isA("::IDHT::DHTNode", ctx))
            {
                DHTNodePrxHelper h = new DHTNodePrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static DHTNodePrx checkedCast(Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA("::IDHT::DHTNode"))
                {
                    DHTNodePrxHelper h = new DHTNodePrxHelper();
                    h.copyFrom__(bb);
                    return h;
                }
            }
            catch(Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static DHTNodePrx checkedCast(Ice.ObjectPrx b, string f, _System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA("::IDHT::DHTNode", ctx))
                {
                    DHTNodePrxHelper h = new DHTNodePrxHelper();
                    h.copyFrom__(bb);
                    return h;
                }
            }
            catch(Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static DHTNodePrx uncheckedCast(Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            DHTNodePrx r = b as DHTNodePrx;
            if(r == null)
            {
                DHTNodePrxHelper h = new DHTNodePrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static DHTNodePrx uncheckedCast(Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            DHTNodePrxHelper h = new DHTNodePrxHelper();
            h.copyFrom__(bb);
            return h;
        }

        #endregion

        #region Marshaling support

        protected override Ice.ObjectDelM_ createDelegateM__()
        {
            return new DHTNodeDelM_();
        }

        protected override Ice.ObjectDelD_ createDelegateD__()
        {
            return new DHTNodeDelD_();
        }

        public static void write__(IceInternal.BasicStream os__, DHTNodePrx v__)
        {
            os__.writeProxy(v__);
        }

        public static DHTNodePrx read__(IceInternal.BasicStream is__)
        {
            Ice.ObjectPrx proxy = is__.readProxy();
            if(proxy != null)
            {
                DHTNodePrxHelper result = new DHTNodePrxHelper();
                result.copyFrom__(proxy);
                return result;
            }
            return null;
        }

        #endregion
    }
}

namespace IDHT
{
    public interface DHTNodeDel_ : Ice.ObjectDel_
    {
        IDHT.nodeConf newConnected(string id, _System.Collections.Generic.Dictionary<string, string> context__);

        void slaveDisconnected(string id, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, _System.Collections.Generic.Dictionary<string, string> context__);

        void masterDisconnected(string connectTo, IDHT.range subtree, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, _System.Collections.Generic.Dictionary<string, string> context__);

        string searchDHT(string key, _System.Collections.Generic.Dictionary<string, string> context__);

        void insertDHT(string key, string val, _System.Collections.Generic.Dictionary<string, string> context__);
    }
}

namespace IDHT
{
    public sealed class DHTNodeDelM_ : Ice.ObjectDelM_, DHTNodeDel_
    {
        public void insertDHT(string key, string val, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("insertDHT", Ice.OperationMode.Normal, context__);
            try
            {
                try
                {
                    IceInternal.BasicStream os__ = og__.ostr();
                    os__.writeString(key);
                    os__.writeString(val);
                }
                catch(Ice.LocalException ex__)
                {
                    og__.abort(ex__);
                }
                bool ok__ = og__.invoke();
                if(!og__.istr().isEmpty())
                {
                    try
                    {
                        if(!ok__)
                        {
                            try
                            {
                                og__.throwUserException();
                            }
                            catch(Ice.UserException ex__)
                            {
                                throw new Ice.UnknownUserException(ex__.ice_name(), ex__);
                            }
                        }
                        og__.istr().skipEmptyEncaps();
                    }
                    catch(Ice.LocalException ex__)
                    {
                        throw new IceInternal.LocalExceptionWrapper(ex__, false);
                    }
                }
            }
            finally
            {
                handler__.reclaimOutgoing(og__);
            }
        }

        public void masterDisconnected(string connectTo, IDHT.range subtree, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("masterDisconnected", Ice.OperationMode.Normal, context__);
            try
            {
                try
                {
                    IceInternal.BasicStream os__ = og__.ostr();
                    os__.writeString(connectTo);
                    subtree.write__(os__);
                    if(newRanges == null)
                    {
                        os__.writeSize(0);
                    }
                    else
                    {
                        os__.writeSize(newRanges.Length);
                        for(int ix__ = 0; ix__ < newRanges.Length; ++ix__)
                        {
                            newRanges[ix__].write__(os__);
                        }
                    }
                    if(childRanges == null)
                    {
                        os__.writeSize(0);
                    }
                    else
                    {
                        os__.writeSize(childRanges.Length);
                        for(int ix__ = 0; ix__ < childRanges.Length; ++ix__)
                        {
                            (childRanges[ix__] == null ? new IDHT.nodeConf() : childRanges[ix__]).write__(os__);
                        }
                    }
                }
                catch(Ice.LocalException ex__)
                {
                    og__.abort(ex__);
                }
                bool ok__ = og__.invoke();
                if(!og__.istr().isEmpty())
                {
                    try
                    {
                        if(!ok__)
                        {
                            try
                            {
                                og__.throwUserException();
                            }
                            catch(Ice.UserException ex__)
                            {
                                throw new Ice.UnknownUserException(ex__.ice_name(), ex__);
                            }
                        }
                        og__.istr().skipEmptyEncaps();
                    }
                    catch(Ice.LocalException ex__)
                    {
                        throw new IceInternal.LocalExceptionWrapper(ex__, false);
                    }
                }
            }
            finally
            {
                handler__.reclaimOutgoing(og__);
            }
        }

        public IDHT.nodeConf newConnected(string id, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("newConnected", Ice.OperationMode.Normal, context__);
            try
            {
                try
                {
                    IceInternal.BasicStream os__ = og__.ostr();
                    os__.writeString(id);
                }
                catch(Ice.LocalException ex__)
                {
                    og__.abort(ex__);
                }
                bool ok__ = og__.invoke();
                try
                {
                    if(!ok__)
                    {
                        try
                        {
                            og__.throwUserException();
                        }
                        catch(Ice.UserException ex__)
                        {
                            throw new Ice.UnknownUserException(ex__.ice_name(), ex__);
                        }
                    }
                    IceInternal.BasicStream is__ = og__.istr();
                    is__.startReadEncaps();
                    IDHT.nodeConf ret__;
                    ret__ = null;
                    if(ret__ == null)
                    {
                        ret__ = new IDHT.nodeConf();
                    }
                    ret__.read__(is__);
                    is__.endReadEncaps();
                    return ret__;
                }
                catch(Ice.LocalException ex__)
                {
                    throw new IceInternal.LocalExceptionWrapper(ex__, false);
                }
            }
            finally
            {
                handler__.reclaimOutgoing(og__);
            }
        }

        public string searchDHT(string key, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("searchDHT", Ice.OperationMode.Normal, context__);
            try
            {
                try
                {
                    IceInternal.BasicStream os__ = og__.ostr();
                    os__.writeString(key);
                }
                catch(Ice.LocalException ex__)
                {
                    og__.abort(ex__);
                }
                bool ok__ = og__.invoke();
                try
                {
                    if(!ok__)
                    {
                        try
                        {
                            og__.throwUserException();
                        }
                        catch(Ice.UserException ex__)
                        {
                            throw new Ice.UnknownUserException(ex__.ice_name(), ex__);
                        }
                    }
                    IceInternal.BasicStream is__ = og__.istr();
                    is__.startReadEncaps();
                    string ret__;
                    ret__ = is__.readString();
                    is__.endReadEncaps();
                    return ret__;
                }
                catch(Ice.LocalException ex__)
                {
                    throw new IceInternal.LocalExceptionWrapper(ex__, false);
                }
            }
            finally
            {
                handler__.reclaimOutgoing(og__);
            }
        }

        public void slaveDisconnected(string id, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("slaveDisconnected", Ice.OperationMode.Normal, context__);
            try
            {
                try
                {
                    IceInternal.BasicStream os__ = og__.ostr();
                    os__.writeString(id);
                    if(newRanges == null)
                    {
                        os__.writeSize(0);
                    }
                    else
                    {
                        os__.writeSize(newRanges.Length);
                        for(int ix__ = 0; ix__ < newRanges.Length; ++ix__)
                        {
                            newRanges[ix__].write__(os__);
                        }
                    }
                    if(childRanges == null)
                    {
                        os__.writeSize(0);
                    }
                    else
                    {
                        os__.writeSize(childRanges.Length);
                        for(int ix__ = 0; ix__ < childRanges.Length; ++ix__)
                        {
                            (childRanges[ix__] == null ? new IDHT.nodeConf() : childRanges[ix__]).write__(os__);
                        }
                    }
                }
                catch(Ice.LocalException ex__)
                {
                    og__.abort(ex__);
                }
                bool ok__ = og__.invoke();
                if(!og__.istr().isEmpty())
                {
                    try
                    {
                        if(!ok__)
                        {
                            try
                            {
                                og__.throwUserException();
                            }
                            catch(Ice.UserException ex__)
                            {
                                throw new Ice.UnknownUserException(ex__.ice_name(), ex__);
                            }
                        }
                        og__.istr().skipEmptyEncaps();
                    }
                    catch(Ice.LocalException ex__)
                    {
                        throw new IceInternal.LocalExceptionWrapper(ex__, false);
                    }
                }
            }
            finally
            {
                handler__.reclaimOutgoing(og__);
            }
        }
    }
}

namespace IDHT
{
    public sealed class DHTNodeDelD_ : Ice.ObjectDelD_, DHTNodeDel_
    {
        public void insertDHT(string key, string val, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            Ice.Current current__ = new Ice.Current();
            initCurrent__(ref current__, "insertDHT", Ice.OperationMode.Normal, context__);
            IceInternal.Direct.RunDelegate run__ = delegate(Ice.Object obj__)
            {
                DHTNode servant__ = null;
                try
                {
                    servant__ = (DHTNode)obj__;
                }
                catch(_System.InvalidCastException)
                {
                    throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
                }
                servant__.insertDHT(key, val, current__);
                return Ice.DispatchStatus.DispatchOK;
            };
            IceInternal.Direct direct__ = null;
            try
            {
                direct__ = new IceInternal.Direct(current__, run__);
                try
                {
                    Ice.DispatchStatus status__ = direct__.servant().collocDispatch__(direct__);
                    _System.Diagnostics.Debug.Assert(status__ == Ice.DispatchStatus.DispatchOK);
                }
                finally
                {
                    direct__.destroy();
                }
            }
            catch(Ice.SystemException)
            {
                throw;
            }
            catch(System.Exception ex__)
            {
                IceInternal.LocalExceptionWrapper.throwWrapper(ex__);
            }
        }

        public void masterDisconnected(string connectTo, IDHT.range subtree, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            Ice.Current current__ = new Ice.Current();
            initCurrent__(ref current__, "masterDisconnected", Ice.OperationMode.Normal, context__);
            IceInternal.Direct.RunDelegate run__ = delegate(Ice.Object obj__)
            {
                DHTNode servant__ = null;
                try
                {
                    servant__ = (DHTNode)obj__;
                }
                catch(_System.InvalidCastException)
                {
                    throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
                }
                servant__.masterDisconnected(connectTo, subtree, newRanges, childRanges, current__);
                return Ice.DispatchStatus.DispatchOK;
            };
            IceInternal.Direct direct__ = null;
            try
            {
                direct__ = new IceInternal.Direct(current__, run__);
                try
                {
                    Ice.DispatchStatus status__ = direct__.servant().collocDispatch__(direct__);
                    _System.Diagnostics.Debug.Assert(status__ == Ice.DispatchStatus.DispatchOK);
                }
                finally
                {
                    direct__.destroy();
                }
            }
            catch(Ice.SystemException)
            {
                throw;
            }
            catch(System.Exception ex__)
            {
                IceInternal.LocalExceptionWrapper.throwWrapper(ex__);
            }
        }

        public IDHT.nodeConf newConnected(string id, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            Ice.Current current__ = new Ice.Current();
            initCurrent__(ref current__, "newConnected", Ice.OperationMode.Normal, context__);
            IDHT.nodeConf result__ = new IDHT.nodeConf();
            IceInternal.Direct.RunDelegate run__ = delegate(Ice.Object obj__)
            {
                DHTNode servant__ = null;
                try
                {
                    servant__ = (DHTNode)obj__;
                }
                catch(_System.InvalidCastException)
                {
                    throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
                }
                result__ = servant__.newConnected(id, current__);
                return Ice.DispatchStatus.DispatchOK;
            };
            IceInternal.Direct direct__ = null;
            try
            {
                direct__ = new IceInternal.Direct(current__, run__);
                try
                {
                    Ice.DispatchStatus status__ = direct__.servant().collocDispatch__(direct__);
                    _System.Diagnostics.Debug.Assert(status__ == Ice.DispatchStatus.DispatchOK);
                }
                finally
                {
                    direct__.destroy();
                }
            }
            catch(Ice.SystemException)
            {
                throw;
            }
            catch(System.Exception ex__)
            {
                IceInternal.LocalExceptionWrapper.throwWrapper(ex__);
            }
            return result__;
        }

        public string searchDHT(string key, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            Ice.Current current__ = new Ice.Current();
            initCurrent__(ref current__, "searchDHT", Ice.OperationMode.Normal, context__);
            string result__ = null;
            IceInternal.Direct.RunDelegate run__ = delegate(Ice.Object obj__)
            {
                DHTNode servant__ = null;
                try
                {
                    servant__ = (DHTNode)obj__;
                }
                catch(_System.InvalidCastException)
                {
                    throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
                }
                result__ = servant__.searchDHT(key, current__);
                return Ice.DispatchStatus.DispatchOK;
            };
            IceInternal.Direct direct__ = null;
            try
            {
                direct__ = new IceInternal.Direct(current__, run__);
                try
                {
                    Ice.DispatchStatus status__ = direct__.servant().collocDispatch__(direct__);
                    _System.Diagnostics.Debug.Assert(status__ == Ice.DispatchStatus.DispatchOK);
                }
                finally
                {
                    direct__.destroy();
                }
            }
            catch(Ice.SystemException)
            {
                throw;
            }
            catch(System.Exception ex__)
            {
                IceInternal.LocalExceptionWrapper.throwWrapper(ex__);
            }
            return result__;
        }

        public void slaveDisconnected(string id, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            Ice.Current current__ = new Ice.Current();
            initCurrent__(ref current__, "slaveDisconnected", Ice.OperationMode.Normal, context__);
            IceInternal.Direct.RunDelegate run__ = delegate(Ice.Object obj__)
            {
                DHTNode servant__ = null;
                try
                {
                    servant__ = (DHTNode)obj__;
                }
                catch(_System.InvalidCastException)
                {
                    throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
                }
                servant__.slaveDisconnected(id, newRanges, childRanges, current__);
                return Ice.DispatchStatus.DispatchOK;
            };
            IceInternal.Direct direct__ = null;
            try
            {
                direct__ = new IceInternal.Direct(current__, run__);
                try
                {
                    Ice.DispatchStatus status__ = direct__.servant().collocDispatch__(direct__);
                    _System.Diagnostics.Debug.Assert(status__ == Ice.DispatchStatus.DispatchOK);
                }
                finally
                {
                    direct__.destroy();
                }
            }
            catch(Ice.SystemException)
            {
                throw;
            }
            catch(System.Exception ex__)
            {
                IceInternal.LocalExceptionWrapper.throwWrapper(ex__);
            }
        }
    }
}

namespace IDHT
{
    public abstract class DHTNodeDisp_ : Ice.ObjectImpl, DHTNode
    {
        #region Slice operations

        public IDHT.nodeConf newConnected(string id)
        {
            return newConnected(id, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract IDHT.nodeConf newConnected(string id, Ice.Current current__);

        public void slaveDisconnected(string id, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges)
        {
            slaveDisconnected(id, newRanges, childRanges, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract void slaveDisconnected(string id, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, Ice.Current current__);

        public void masterDisconnected(string connectTo, IDHT.range subtree, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges)
        {
            masterDisconnected(connectTo, subtree, newRanges, childRanges, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract void masterDisconnected(string connectTo, IDHT.range subtree, IDHT.range[] newRanges, IDHT.nodeConf[] childRanges, Ice.Current current__);

        public string searchDHT(string key)
        {
            return searchDHT(key, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract string searchDHT(string key, Ice.Current current__);

        public void insertDHT(string key, string val)
        {
            insertDHT(key, val, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract void insertDHT(string key, string val, Ice.Current current__);

        #endregion

        #region Slice type-related members

        public static new string[] ids__ = 
        {
            "::IDHT::DHTNode",
            "::Ice::Object"
        };

        public override bool ice_isA(string s)
        {
            return _System.Array.BinarySearch(ids__, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
        }

        public override bool ice_isA(string s, Ice.Current current__)
        {
            return _System.Array.BinarySearch(ids__, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
        }

        public override string[] ice_ids()
        {
            return ids__;
        }

        public override string[] ice_ids(Ice.Current current__)
        {
            return ids__;
        }

        public override string ice_id()
        {
            return ids__[0];
        }

        public override string ice_id(Ice.Current current__)
        {
            return ids__[0];
        }

        public static new string ice_staticId()
        {
            return ids__[0];
        }

        #endregion

        #region Operation dispatch

        public static Ice.DispatchStatus newConnected___(DHTNode obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.istr();
            is__.startReadEncaps();
            string id;
            id = is__.readString();
            is__.endReadEncaps();
            IceInternal.BasicStream os__ = inS__.ostr();
            IDHT.nodeConf ret__ = obj__.newConnected(id, current__);
            if(ret__ == null)
            {
                IDHT.nodeConf tmp__ = new IDHT.nodeConf();
                tmp__.write__(os__);
            }
            else
            {
                ret__.write__(os__);
            }
            return Ice.DispatchStatus.DispatchOK;
        }

        public static Ice.DispatchStatus slaveDisconnected___(DHTNode obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.istr();
            is__.startReadEncaps();
            string id;
            id = is__.readString();
            IDHT.range[] newRanges;
            {
                int szx__ = is__.readSize();
                is__.checkFixedSeq(szx__, 8);
                newRanges = new IDHT.range[szx__];
                for(int ix__ = 0; ix__ < szx__; ++ix__)
                {
                    newRanges[ix__].read__(is__);
                }
            }
            IDHT.nodeConf[] childRanges;
            {
                int szx__ = is__.readSize();
                is__.startSeq(szx__, 11);
                childRanges = new IDHT.nodeConf[szx__];
                for(int ix__ = 0; ix__ < szx__; ++ix__)
                {
                    childRanges[ix__] = new IDHT.nodeConf();
                    childRanges[ix__].read__(is__);
                    is__.checkSeq();
                    is__.endElement();
                }
                is__.endSeq(szx__);
            }
            is__.endReadEncaps();
            obj__.slaveDisconnected(id, newRanges, childRanges, current__);
            return Ice.DispatchStatus.DispatchOK;
        }

        public static Ice.DispatchStatus masterDisconnected___(DHTNode obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.istr();
            is__.startReadEncaps();
            string connectTo;
            connectTo = is__.readString();
            IDHT.range subtree;
            subtree = new IDHT.range();
            subtree.read__(is__);
            IDHT.range[] newRanges;
            {
                int szx__ = is__.readSize();
                is__.checkFixedSeq(szx__, 8);
                newRanges = new IDHT.range[szx__];
                for(int ix__ = 0; ix__ < szx__; ++ix__)
                {
                    newRanges[ix__].read__(is__);
                }
            }
            IDHT.nodeConf[] childRanges;
            {
                int szx__ = is__.readSize();
                is__.startSeq(szx__, 11);
                childRanges = new IDHT.nodeConf[szx__];
                for(int ix__ = 0; ix__ < szx__; ++ix__)
                {
                    childRanges[ix__] = new IDHT.nodeConf();
                    childRanges[ix__].read__(is__);
                    is__.checkSeq();
                    is__.endElement();
                }
                is__.endSeq(szx__);
            }
            is__.endReadEncaps();
            obj__.masterDisconnected(connectTo, subtree, newRanges, childRanges, current__);
            return Ice.DispatchStatus.DispatchOK;
        }

        public static Ice.DispatchStatus searchDHT___(DHTNode obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.istr();
            is__.startReadEncaps();
            string key;
            key = is__.readString();
            is__.endReadEncaps();
            IceInternal.BasicStream os__ = inS__.ostr();
            string ret__ = obj__.searchDHT(key, current__);
            os__.writeString(ret__);
            return Ice.DispatchStatus.DispatchOK;
        }

        public static Ice.DispatchStatus insertDHT___(DHTNode obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.istr();
            is__.startReadEncaps();
            string key;
            key = is__.readString();
            string val;
            val = is__.readString();
            is__.endReadEncaps();
            obj__.insertDHT(key, val, current__);
            return Ice.DispatchStatus.DispatchOK;
        }

        private static string[] all__ =
        {
            "ice_id",
            "ice_ids",
            "ice_isA",
            "ice_ping",
            "insertDHT",
            "masterDisconnected",
            "newConnected",
            "searchDHT",
            "slaveDisconnected"
        };

        public override Ice.DispatchStatus dispatch__(IceInternal.Incoming inS__, Ice.Current current__)
        {
            int pos = _System.Array.BinarySearch(all__, current__.operation, IceUtilInternal.StringUtil.OrdinalStringComparer);
            if(pos < 0)
            {
                throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
            }

            switch(pos)
            {
                case 0:
                {
                    return ice_id___(this, inS__, current__);
                }
                case 1:
                {
                    return ice_ids___(this, inS__, current__);
                }
                case 2:
                {
                    return ice_isA___(this, inS__, current__);
                }
                case 3:
                {
                    return ice_ping___(this, inS__, current__);
                }
                case 4:
                {
                    return insertDHT___(this, inS__, current__);
                }
                case 5:
                {
                    return masterDisconnected___(this, inS__, current__);
                }
                case 6:
                {
                    return newConnected___(this, inS__, current__);
                }
                case 7:
                {
                    return searchDHT___(this, inS__, current__);
                }
                case 8:
                {
                    return slaveDisconnected___(this, inS__, current__);
                }
            }

            _System.Diagnostics.Debug.Assert(false);
            throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
        }

        #endregion

        #region Marshaling support

        public override void write__(IceInternal.BasicStream os__)
        {
            os__.writeTypeId(ice_staticId());
            os__.startWriteSlice();
            os__.endWriteSlice();
            base.write__(os__);
        }

        public override void read__(IceInternal.BasicStream is__, bool rid__)
        {
            if(rid__)
            {
                /* string myId = */ is__.readTypeId();
            }
            is__.startReadSlice();
            is__.endReadSlice();
            base.read__(is__, true);
        }

        public override void write__(Ice.OutputStream outS__)
        {
            Ice.MarshalException ex = new Ice.MarshalException();
            ex.reason = "type IDHT::DHTNode was not generated with stream support";
            throw ex;
        }

        public override void read__(Ice.InputStream inS__, bool rid__)
        {
            Ice.MarshalException ex = new Ice.MarshalException();
            ex.reason = "type IDHT::DHTNode was not generated with stream support";
            throw ex;
        }

        #endregion
    }
}
