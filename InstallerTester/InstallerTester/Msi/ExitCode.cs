namespace InstallerTester.Msi
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/desktop/msi/error-codes
    /// </summary>
    public enum ExitCode
    {
        Success = 0,

        // The data is invalid.
        INVALID_DATA = 13,

        //	One of the parameters was invalid.
        INVALID_PARAMETER = 87,
        
        // This value is returned when a custom action attempts to call a function that cannot be called from custom actions.The function returns the value CALL_NOT_IMPLEMENTED. Available beginning with Windows Installer version 3.0.
        CALL_NOT_IMPLEMENTED = 120,

        //	If Windows Installer determines a product may be incompatible with the current operating system, it displays a dialog box informing the user and asking whether to try to install anyway.This error code is returned if the user chooses not to try the installation.
        APPHELP_BLOCK = 1259,
        
        // The Windows Installer service could not be accessed.Contact your support personnel to verify that the Windows Installer service is properly registered.
        INSTALL_SERVICE_FAILURE = 1601,
        
        // The user cancels installation.
        INSTALL_USEREXIT = 1602,
        
        //	A fatal error occurred during installation.
        INSTALL_FAILURE = 1603,

        INSTALL_SUSPEND = 1604,// Installation suspended, incomplete.
        UNKNOWN_PRODUCT = 1605, // This action is only valid for products that are currently installed.
        UNKNOWN_FEATURE = 1606, //	The feature identifier is not registered.
        UNKNOWN_COMPONENT = 1607, //	The component identifier is not registered.
        UNKNOWN_PROPERTY = 1608, //	This is an unknown property.
        INVALID_HANDLE_STATE = 1609, //	The handle is in an invalid state.
        BAD_CONFIGURATION = 1610, //	The configuration data for this product is corrupt.Contact your support personnel.
        INDEX_ABSENT = 1611, //	The component qualifier not present.
        INSTALL_SOURCE_ABSENT = 1612, //	The installation source for this product is not available. Verify that the source exists and that you can access it.
        INSTALL_PACKAGE_VERSION = 1613, //	This installation package cannot be installed by the Windows Installer service.You must install a Windows service pack that contains a newer version of the Windows Installer service.
        PRODUCT_UNINSTALLED = 1614, //	The product is uninstalled.
        BAD_QUERY_SYNTAX = 1615, //	The SQL query syntax is invalid or unsupported.
        INVALID_FIELD = 1616, //	The record field does not exist.
        INSTALL_ALREADY_RUNNING = 1618, //	Another installation is already in progress.Complete that installation before proceeding with this install.For information about the mutex, see _MSIExecute Mutex.
        INSTALL_PACKAGE_OPEN_FAILED = 1619, //	This installation package could not be opened.Verify that the package exists and is accessible, or contact the application vendor to verify that this is a valid Windows Installer package.
        INSTALL_PACKAGE_INVALID = 1620, //	This installation package could not be opened.Contact the application vendor to verify that this is a valid Windows Installer package.
        INSTALL_UI_FAILURE = 1621, //	There was an error starting the Windows Installer service user interface. Contact your support personnel.
        INSTALL_LOG_FAILURE = 1622, //	There was an error opening installation log file. Verify that the specified log file location exists and is writable.
        INSTALL_LANGUAGE_UNSUPPORTED = 1623, //	This language of this installation package is not supported by your system.
        INSTALL_TRANSFORM_FAILURE = 1624, //	There was an error applying transforms. Verify that the specified transform paths are valid.
        INSTALL_PACKAGE_REJECTED = 1625, //	This installation is forbidden by system policy. Contact your system administrator.
        FUNCTION_NOT_CALLED = 1626, //	The function could not be executed.
        FUNCTION_FAILED = 1627, //	The function failed during execution.
        INVALID_TABLE = 1628, //	An invalid or unknown table was specified.
        DATATYPE_MISMATCH = 1629, //	The data supplied is the wrong type.
        UNSUPPORTED_TYPE = 1630, //	Data of this type is not supported.
        CREATE_FAILED = 1631, //	The Windows Installer service failed to start.Contact your support personnel.
        INSTALL_TEMP_UNWRITABLE = 1632, //	The Temp folder is either full or inaccessible. Verify that the Temp folder exists and that you can write to it.
        INSTALL_PLATFORM_UNSUPPORTED = 1633, //	This installation package is not supported on this platform.Contact your application vendor.
        INSTALL_NOTUSED = 1634, //	Component is not used on this machine.
        PATCH_PACKAGE_OPEN_FAILED = 1635, //	This patch package could not be opened.Verify that the patch package exists and is accessible, or contact the application vendor to verify that this is a valid Windows Installer patch package.
        PATCH_PACKAGE_INVALID = 1636, //	This patch package could not be opened.Contact the application vendor to verify that this is a valid Windows Installer patch package.
        PATCH_PACKAGE_UNSUPPORTED = 1637, //	This patch package cannot be processed by the Windows Installer service.You must install a Windows service pack that contains a newer version of the Windows Installer service.
        PRODUCT_VERSION = 1638, //	Another version of this product is already installed. Installation of this version cannot continue. To configure or remove the existing version of this product, use Add/Remove Programs in Control Panel.
        INVALID_COMMAND_LINE = 1639, //	Invalid command line argument. Consult the Windows Installer SDK for detailed command-line help.
        INSTALL_REMOTE_DISALLOWED = 1640, //	The current user is not permitted to perform installations from a client session of a server running the Terminal Server role service.
        SUCCESS_REBOOT_INITIATED = 1641, //	The installer has initiated a restart. This message is indicative of a success.
        PATCH_TARGET_NOT_FOUND = 1642, //	The installer cannot install the upgrade patch because the program being upgraded may be missing or the upgrade patch updates a different version of the program. Verify that the program to be upgraded exists on your computer and that you have the correct upgrade patch.
        PATCH_PACKAGE_REJECTED = 1643, //	The patch package is not permitted by system policy.
        INSTALL_TRANSFORM_REJECTED = 1644, //	One or more customizations are not permitted by system policy.
        INSTALL_REMOTE_PROHIBITED = 1645, //	Windows Installer does not permit installation from a Remote Desktop Connection.
        PATCH_REMOVAL_UNSUPPORTED = 1646, //	The patch package is not a removable patch package.Available beginning with Windows Installer version =1646 , //.=1646 , //.
        UNKNOWN_PATCH = 1647, //	The patch is not applied to this product.Available beginning with Windows Installer version =1647 , //.=1647 , //.
        PATCH_NO_SEQUENCE = 1648, //	No valid sequence could be found for the set of patches. Available beginning with Windows Installer version =1648 , //.=1648 , //.
        PATCH_REMOVAL_DISALLOWED = 1649, //	Patch removal was disallowed by policy. Available beginning with Windows Installer version =1649 , //.=1649 , //.
        INVALID_PATCH_XML = 1650, //	The XML patch data is invalid.Available beginning with Windows Installer version =1650 , //.=1650 , //.
        PATCH_MANAGED_ADVERTISED_PRODUCT = 1651, //	Administrative user failed to apply patch for a per-user managed or a per-machine application that is in advertise state. Available beginning with Windows Installer version =1651 , //.=1651 , //.
        INSTALL_SERVICE_SAFEBOOT = 1652, //	Windows Installer is not accessible when the computer is in Safe Mode. Exit Safe Mode and try again or try using System Restore to return your computer to a previous state.Available beginning with Windows Installer version =1652 , //.=1652 , //.
        ROLLBACK_DISABLED = 1653, //	Could not perform a multiple-package transaction because rollback has been disabled.Multiple-Package Installations cannot run if rollback is disabled.Available beginning with Windows Installer version =1653 , //.=1653 , //.
        INSTALL_REJECTED = 1654, //	The app that you are trying to run is not supported on this version of Windows.A Windows Installer package, patch, or transform that has not been signed by Microsoft cannot be installed on an ARM computer.
        SUCCESS_REBOOT_REQUIRED = 3010, //	A restart is required to complete the install.This message is indicative of a success. This does not include installs where the ForceReboot action is run.
    }

    public static class ExitCodeHelper
    {
        public static bool IsSuccess(int exitCode)
        {
            return true ?
                (ExitCode)exitCode == ExitCode.Success || (ExitCode)exitCode == ExitCode.SUCCESS_REBOOT_INITIATED || (ExitCode)exitCode == ExitCode.SUCCESS_REBOOT_REQUIRED : 
                false;
        }
    }
}
