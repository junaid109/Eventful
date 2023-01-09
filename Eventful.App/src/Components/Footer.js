import React from 'react'

const Footer = () => {
  return (
    <div>
    {/* create footer component with tailwindcss  */}
        <footer className="bg-gray-800">
            <div className="max-w-7xl mx-auto py-12 px-4 overflow-hidden sm:px-6 lg:px-8">
                <nav className="-mx-5 -my-2 flex flex-wrap justify-center" aria-label="Footer">
                    <div className="px-5 py-2">
                        <a href="#" className="text-base text-gray-500 hover:text-gray-900">
                            About
                        </a>
                        <a href="#" className="text-base text-gray-500 hover:text-gray-900">
                            Blog
                        </a>
                        <a href="#" className="text-base text-gray-500 hover:text-gray-900">
                            Jobs
                        </a>
                        <a href="#" className="text-base text-gray-500 hover:text-gray-900">
                            Press
                        </a>
                        <a href="#" className="text-base text-gray-500 hover:text-gray-900">
                            Privacy
                        </a>
                        <a href="#" className="text-base text-gray-500 hover:text-gray-900">
                            Terms
                        </a>
                            <a href="#" className="text-base text-gray-500 hover:text-gray-900">
                            Contact
                        </a>
                        <a href="#" className="text-base text-gray-500 hover:text-gray-900">
                            Help
                        </a>
                        <a href="#" className="text-base text-gray-500 hover:text-gray-900">
                            Status
                        </a>
                        <a href="#" className="text-base text-gray-500 hover:text-gray-900">
                            Partners
                        </a>
                        <a href="#" className="text-base text-gray-500 hover:text-gray-900">
                            Vendors
                        </a>
                    </div>
                </nav>
                <p className="mt-8 text-center text-base text-gray-400">
                    &copy; 2023 Junaid Malik, Inc. All rights reserved.
                </p>
                <p className="mt-8 text-center text-base text-gray-400">
                    Made with <span className="text-red-500">&hearts;</span> by <a href="" className="text-gray-500 hover:text-gray-900">React JS</a>
                </p>
                </div>

                </footer>
    </div>
  )
}

export default Footer