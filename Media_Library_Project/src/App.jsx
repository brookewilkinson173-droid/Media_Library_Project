
import { useState } from 'react'
import booksImg from './assets/books.png'
import reactLogo from './assets/react.svg'
import viteLogo from './assets/vite.svg'
import smartmicroGif from './assets/smartmicro.gif'
import smartmovieGif from './assets/smartmovie.gif'
import smarttvGif from './assets/smarttv.gif'
import './App.css'
import MediaTypeDropdown from './MediaTypeDropdown'

function App() {
  const [count, setCount] = useState(0)
  const [media, setMedia] = useState('All Media')
  const [loading, setLoading] = useState(false)
  const [connectionError, setConnectionError] = useState('')

  const mediaImages = {
    'All Media': booksImg,
    Songs: smartmicroGif,
    Shows: smarttvGif,
    Movies: smartmovieGif,
  }

  const testConnection = async () => {
    const nextCount = count + 1
    setCount(nextCount)
    setLoading(true)
    setConnectionError('')

    try {
      const response = await fetch('/api/test-connection', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({
          message: `Hello from React! Count: ${nextCount}`,
        }),
      })

      if (!response.ok) {
        throw new Error(`HTTP error: ${response.status}`)
      }

      const result = await response.json()
      console.log('Backend response:', result)
    } catch (error) {
      console.error('Backend connection failed:', error)
      setConnectionError(error.message || 'Connection failed')
    } finally {
      setLoading(false)
    }
  }

  return (
    <>
      <section id="center">
        <div className="titlebar">
          <img
            src={mediaImages[media]}
            className="base"
            width="170"
            height="179"
            alt=""
          />
        </div>

        <div>
          <h1>Digital Library</h1>
          <p>by zachary, brooke, and veronica</p>
        </div>

        <button
          type="button"
          className="counter"
          onClick={testConnection}
          disabled={loading}
        >
          {loading ? 'Testing connection...' : `Count is ${count}`}
        </button>

        {connectionError && (
          <p role="alert">{connectionError}</p>
        )}
      </section>

      <div className="searchbar">
        <input type="text" placeholder="Search..." />

        <select
          value={media}
          onChange={(event) => setMedia(event.target.value)}
        >
          <option value="All Media">All Media</option>
          <option value="Songs">Songs</option>
          <option value="Shows">Shows</option>
          <option value="Movies">Movies</option>
        </select>
      </div>

      <div className="media-dropdown">
        <h2>Media Library</h2>
        <MediaTypeDropdown />
      </div>

      <div className="div1"></div>

      <section id="next-steps">
        <div id="docs">
          <svg className="icon" role="presentation" aria-hidden="true">
            <use href="/icons.svg#documentation-icon"></use>
          </svg>

          <h2>Documentation</h2>
          <p>Your questions, answered</p>

          <ul>
            <li>
              <a href="https://vite.dev/" target="_blank" rel="noreferrer">
                <img className="logo" src={viteLogo} alt="" />
                Explore Vite
              </a>
            </li>
            <li>
              <a href="https://react.dev/" target="_blank" rel="noreferrer">
                <img className="button-icon" src={reactLogo} alt="" />
                Learn more
              </a>
            </li>
          </ul>
        </div>
      </section>

      <div className="ticks"></div>
      <section id="spacer"></section>
    </>
  )
}

export default App
