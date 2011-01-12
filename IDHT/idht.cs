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
    public interface DHTNode : Ice.Object, DHTNodeOperations_, DHTNodeOperationsNC_
    {
    }

    public interface DHTMaster : Ice.Object, DHTMasterOperations_, DHTMasterOperationsNC_
    {
    }
}

namespace IDHT
{
    public interface DHTNodePrx : Ice.ObjectPrx
    {
        string connected(string connectingId);
        string connected(string connectingId, _System.Collections.Generic.Dictionary<string, string> context__);

        void disconnected(string id, string connectTo);
        void disconnected(string id, string connectTo, _System.Collections.Generic.Dictionary<string, string> context__);

        string seatchDHT(string key);
        string seatchDHT(string key, _System.Collections.Generic.Dictionary<string, string> context__);

        void insertDHT(string key, string value);
        void insertDHT(string key, string value, _System.Collections.Generic.Dictionary<string, string> context__);
    }

    public interface DHTMasterPrx : Ice.ObjectPrx
    {
        string getUniqId();
        string getUniqId(_System.Collections.Generic.Dictionary<string, string> context__);
    }
}

namespace IDHT
{
    public interface DHTNodeOperations_
    {
        string connected(string connectingId, Ice.Current current__);

        void disconnected(string id, string connectTo, Ice.Current current__);

        string seatchDHT(string key, Ice.Current current__);

        void insertDHT(string key, string value, Ice.Current current__);
    }

    public interface DHTNodeOperationsNC_
    {
        string connected(string connectingId);

        void disconnected(string id, string connectTo);

        string seatchDHT(string key);

        void insertDHT(string key, string value);
    }

    public interface DHTMasterOperations_
    {
        string getUniqId(Ice.Current current__);
    }

    public interface DHTMasterOperationsNC_
    {
        string getUniqId();
    }
}

namespace IDHT
{
    public sealed class DHTNodePrxHelper : Ice.ObjectPrxHelperBase, DHTNodePrx
    {
        #region Synchronous operations

        public string connected(string connectingId)
        {
            return connected(connectingId, null, false);
        }

        public string connected(string connectingId, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            return connected(connectingId, context__, true);
        }

        private string connected(string connectingId, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
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
                    checkTwowayOnly__("connected");
                    delBase__ = getDelegate__(false);
                    DHTNodeDel_ del__ = (DHTNodeDel_)delBase__;
                    return del__.connected(connectingId, context__);
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

        public void disconnected(string id, string connectTo)
        {
            disconnected(id, connectTo, null, false);
        }

        public void disconnected(string id, string connectTo, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            disconnected(id, connectTo, context__, true);
        }

        private void disconnected(string id, string connectTo, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
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
                    del__.disconnected(id, connectTo, context__);
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

        public void insertDHT(string key, string value)
        {
            insertDHT(key, value, null, false);
        }

        public void insertDHT(string key, string value, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            insertDHT(key, value, context__, true);
        }

        private void insertDHT(string key, string value, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
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
                    del__.insertDHT(key, value, context__);
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

        public string seatchDHT(string key)
        {
            return seatchDHT(key, null, false);
        }

        public string seatchDHT(string key, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            return seatchDHT(key, context__, true);
        }

        private string seatchDHT(string key, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
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
                    checkTwowayOnly__("seatchDHT");
                    delBase__ = getDelegate__(false);
                    DHTNodeDel_ del__ = (DHTNodeDel_)delBase__;
                    return del__.seatchDHT(key, context__);
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

    public sealed class DHTMasterPrxHelper : Ice.ObjectPrxHelperBase, DHTMasterPrx
    {
        #region Synchronous operations

        public string getUniqId()
        {
            return getUniqId(null, false);
        }

        public string getUniqId(_System.Collections.Generic.Dictionary<string, string> context__)
        {
            return getUniqId(context__, true);
        }

        private string getUniqId(_System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
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
                    checkTwowayOnly__("getUniqId");
                    delBase__ = getDelegate__(false);
                    DHTMasterDel_ del__ = (DHTMasterDel_)delBase__;
                    return del__.getUniqId(context__);
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

        public static DHTMasterPrx checkedCast(Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            DHTMasterPrx r = b as DHTMasterPrx;
            if((r == null) && b.ice_isA("::IDHT::DHTMaster"))
            {
                DHTMasterPrxHelper h = new DHTMasterPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static DHTMasterPrx checkedCast(Ice.ObjectPrx b, _System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            DHTMasterPrx r = b as DHTMasterPrx;
            if((r == null) && b.ice_isA("::IDHT::DHTMaster", ctx))
            {
                DHTMasterPrxHelper h = new DHTMasterPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static DHTMasterPrx checkedCast(Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA("::IDHT::DHTMaster"))
                {
                    DHTMasterPrxHelper h = new DHTMasterPrxHelper();
                    h.copyFrom__(bb);
                    return h;
                }
            }
            catch(Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static DHTMasterPrx checkedCast(Ice.ObjectPrx b, string f, _System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA("::IDHT::DHTMaster", ctx))
                {
                    DHTMasterPrxHelper h = new DHTMasterPrxHelper();
                    h.copyFrom__(bb);
                    return h;
                }
            }
            catch(Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static DHTMasterPrx uncheckedCast(Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            DHTMasterPrx r = b as DHTMasterPrx;
            if(r == null)
            {
                DHTMasterPrxHelper h = new DHTMasterPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static DHTMasterPrx uncheckedCast(Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            DHTMasterPrxHelper h = new DHTMasterPrxHelper();
            h.copyFrom__(bb);
            return h;
        }

        #endregion

        #region Marshaling support

        protected override Ice.ObjectDelM_ createDelegateM__()
        {
            return new DHTMasterDelM_();
        }

        protected override Ice.ObjectDelD_ createDelegateD__()
        {
            return new DHTMasterDelD_();
        }

        public static void write__(IceInternal.BasicStream os__, DHTMasterPrx v__)
        {
            os__.writeProxy(v__);
        }

        public static DHTMasterPrx read__(IceInternal.BasicStream is__)
        {
            Ice.ObjectPrx proxy = is__.readProxy();
            if(proxy != null)
            {
                DHTMasterPrxHelper result = new DHTMasterPrxHelper();
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
        string connected(string connectingId, _System.Collections.Generic.Dictionary<string, string> context__);

        void disconnected(string id, string connectTo, _System.Collections.Generic.Dictionary<string, string> context__);

        string seatchDHT(string key, _System.Collections.Generic.Dictionary<string, string> context__);

        void insertDHT(string key, string value, _System.Collections.Generic.Dictionary<string, string> context__);
    }

    public interface DHTMasterDel_ : Ice.ObjectDel_
    {
        string getUniqId(_System.Collections.Generic.Dictionary<string, string> context__);
    }
}

namespace IDHT
{
    public sealed class DHTNodeDelM_ : Ice.ObjectDelM_, DHTNodeDel_
    {
        public string connected(string connectingId, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("connected", Ice.OperationMode.Normal, context__);
            try
            {
                try
                {
                    IceInternal.BasicStream os__ = og__.ostr();
                    os__.writeString(connectingId);
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

        public void disconnected(string id, string connectTo, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("disconnected", Ice.OperationMode.Normal, context__);
            try
            {
                try
                {
                    IceInternal.BasicStream os__ = og__.ostr();
                    os__.writeString(id);
                    os__.writeString(connectTo);
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

        public void insertDHT(string key, string value, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("insertDHT", Ice.OperationMode.Normal, context__);
            try
            {
                try
                {
                    IceInternal.BasicStream os__ = og__.ostr();
                    os__.writeString(key);
                    os__.writeString(value);
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

        public string seatchDHT(string key, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("seatchDHT", Ice.OperationMode.Normal, context__);
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
    }

    public sealed class DHTMasterDelM_ : Ice.ObjectDelM_, DHTMasterDel_
    {
        public string getUniqId(_System.Collections.Generic.Dictionary<string, string> context__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("getUniqId", Ice.OperationMode.Normal, context__);
            try
            {
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
    }
}

namespace IDHT
{
    public sealed class DHTNodeDelD_ : Ice.ObjectDelD_, DHTNodeDel_
    {
        public string connected(string connectingId, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            Ice.Current current__ = new Ice.Current();
            initCurrent__(ref current__, "connected", Ice.OperationMode.Normal, context__);
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
                result__ = servant__.connected(connectingId, current__);
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

        public void disconnected(string id, string connectTo, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            Ice.Current current__ = new Ice.Current();
            initCurrent__(ref current__, "disconnected", Ice.OperationMode.Normal, context__);
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
                servant__.disconnected(id, connectTo, current__);
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

        public void insertDHT(string key, string value, _System.Collections.Generic.Dictionary<string, string> context__)
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
                servant__.insertDHT(key, value, current__);
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

        public string seatchDHT(string key, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            Ice.Current current__ = new Ice.Current();
            initCurrent__(ref current__, "seatchDHT", Ice.OperationMode.Normal, context__);
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
                result__ = servant__.seatchDHT(key, current__);
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
    }

    public sealed class DHTMasterDelD_ : Ice.ObjectDelD_, DHTMasterDel_
    {
        public string getUniqId(_System.Collections.Generic.Dictionary<string, string> context__)
        {
            Ice.Current current__ = new Ice.Current();
            initCurrent__(ref current__, "getUniqId", Ice.OperationMode.Normal, context__);
            string result__ = null;
            IceInternal.Direct.RunDelegate run__ = delegate(Ice.Object obj__)
            {
                DHTMaster servant__ = null;
                try
                {
                    servant__ = (DHTMaster)obj__;
                }
                catch(_System.InvalidCastException)
                {
                    throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
                }
                result__ = servant__.getUniqId(current__);
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
    }
}

namespace IDHT
{
    public abstract class DHTNodeDisp_ : Ice.ObjectImpl, DHTNode
    {
        #region Slice operations

        public string connected(string connectingId)
        {
            return connected(connectingId, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract string connected(string connectingId, Ice.Current current__);

        public void disconnected(string id, string connectTo)
        {
            disconnected(id, connectTo, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract void disconnected(string id, string connectTo, Ice.Current current__);

        public string seatchDHT(string key)
        {
            return seatchDHT(key, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract string seatchDHT(string key, Ice.Current current__);

        public void insertDHT(string key, string value)
        {
            insertDHT(key, value, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract void insertDHT(string key, string value, Ice.Current current__);

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

        public static Ice.DispatchStatus connected___(DHTNode obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.istr();
            is__.startReadEncaps();
            string connectingId;
            connectingId = is__.readString();
            is__.endReadEncaps();
            IceInternal.BasicStream os__ = inS__.ostr();
            string ret__ = obj__.connected(connectingId, current__);
            os__.writeString(ret__);
            return Ice.DispatchStatus.DispatchOK;
        }

        public static Ice.DispatchStatus disconnected___(DHTNode obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.istr();
            is__.startReadEncaps();
            string id;
            id = is__.readString();
            string connectTo;
            connectTo = is__.readString();
            is__.endReadEncaps();
            obj__.disconnected(id, connectTo, current__);
            return Ice.DispatchStatus.DispatchOK;
        }

        public static Ice.DispatchStatus seatchDHT___(DHTNode obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.istr();
            is__.startReadEncaps();
            string key;
            key = is__.readString();
            is__.endReadEncaps();
            IceInternal.BasicStream os__ = inS__.ostr();
            string ret__ = obj__.seatchDHT(key, current__);
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
            string value;
            value = is__.readString();
            is__.endReadEncaps();
            obj__.insertDHT(key, value, current__);
            return Ice.DispatchStatus.DispatchOK;
        }

        private static string[] all__ =
        {
            "connected",
            "disconnected",
            "ice_id",
            "ice_ids",
            "ice_isA",
            "ice_ping",
            "insertDHT",
            "seatchDHT"
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
                    return connected___(this, inS__, current__);
                }
                case 1:
                {
                    return disconnected___(this, inS__, current__);
                }
                case 2:
                {
                    return ice_id___(this, inS__, current__);
                }
                case 3:
                {
                    return ice_ids___(this, inS__, current__);
                }
                case 4:
                {
                    return ice_isA___(this, inS__, current__);
                }
                case 5:
                {
                    return ice_ping___(this, inS__, current__);
                }
                case 6:
                {
                    return insertDHT___(this, inS__, current__);
                }
                case 7:
                {
                    return seatchDHT___(this, inS__, current__);
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

    public abstract class DHTMasterDisp_ : Ice.ObjectImpl, DHTMaster
    {
        #region Slice operations

        public string getUniqId()
        {
            return getUniqId(Ice.ObjectImpl.defaultCurrent);
        }

        public abstract string getUniqId(Ice.Current current__);

        #endregion

        #region Slice type-related members

        public static new string[] ids__ = 
        {
            "::IDHT::DHTMaster",
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

        public static Ice.DispatchStatus getUniqId___(DHTMaster obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            checkMode__(Ice.OperationMode.Normal, current__.mode);
            inS__.istr().skipEmptyEncaps();
            IceInternal.BasicStream os__ = inS__.ostr();
            string ret__ = obj__.getUniqId(current__);
            os__.writeString(ret__);
            return Ice.DispatchStatus.DispatchOK;
        }

        private static string[] all__ =
        {
            "getUniqId",
            "ice_id",
            "ice_ids",
            "ice_isA",
            "ice_ping"
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
                    return getUniqId___(this, inS__, current__);
                }
                case 1:
                {
                    return ice_id___(this, inS__, current__);
                }
                case 2:
                {
                    return ice_ids___(this, inS__, current__);
                }
                case 3:
                {
                    return ice_isA___(this, inS__, current__);
                }
                case 4:
                {
                    return ice_ping___(this, inS__, current__);
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
            ex.reason = "type IDHT::DHTMaster was not generated with stream support";
            throw ex;
        }

        public override void read__(Ice.InputStream inS__, bool rid__)
        {
            Ice.MarshalException ex = new Ice.MarshalException();
            ex.reason = "type IDHT::DHTMaster was not generated with stream support";
            throw ex;
        }

        #endregion
    }
}
